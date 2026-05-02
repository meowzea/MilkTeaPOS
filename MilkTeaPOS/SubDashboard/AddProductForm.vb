Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math

Public Class AddProductForm



    Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
    Dim query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Public Property ReceivedProductValue() As String
    Dim form1Init As New MainForm

    Public Sub UpdateCart()
        Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
        Dim cartDT As New DataTable
        Dim cartTable As New MySqlDataAdapter("SELECT OrderID, Variant, Size, SugarLevel,Price, Quantity, Addon, AddonName, Total FROM cart;", connection)

        cartTable.Fill(cartDT)

        BuyForm.DataGridViewCart.DataSource = cartDT
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        Me.Close()
        MainForm.BringToFront()
    End Sub

    Public Sub ReloadSizeComBox()
        Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
        Dim adapter As New MySqlDataAdapter("SELECT sizeName FROM size;", connection)
        Dim table As New DataTable

        adapter.Fill(table)

        comboBoxSize.DataSource = table

        comboBoxSize.ValueMember = ""
        comboBoxSize.DisplayMember = "sizeName"
    End Sub

    Public Sub ReloadAddonComBox()
        'comment
        Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
        Dim adapter As New MySqlDataAdapter("SELECT addOnsName FROM addons;", connection)
        Dim table As New DataTable

        adapter.Fill(table)

        comboBoxAddon.DataSource = table

        comboBoxAddon.ValueMember = ""
        comboBoxAddon.DisplayMember = "addOnsName"
    End Sub

    Public Sub ReloadAddonComBox1()
        Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
        Dim adapter As New MySqlDataAdapter("SELECT addOnsName FROM addons;", connection)
        Dim table As New DataTable

        adapter.Fill(table)

        comboBoxAddon1.DataSource = table

        comboBoxAddon1.ValueMember = ""
        comboBoxAddon1.DisplayMember = "addOnsName"
    End Sub

    Public Sub ReloadAddonComBox2()
        Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
        Dim adapter As New MySqlDataAdapter("SELECT addOnsName FROM addons;", connection)
        Dim table As New DataTable

        adapter.Fill(table)

        comboBoxAddon2.DataSource = table

        comboBoxAddon2.ValueMember = ""
        comboBoxAddon2.DisplayMember = "addOnsName"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadSizeComBox()
        ReloadAddonComBox()
        ReloadAddonComBox1()
        ReloadAddonComBox2()
        formTwoProduct.Text = ReceivedProductValue()
        formTwoProduct.ReadOnly = True
        formTwoProduct.Enabled = False
    End Sub

    Dim myPrice As Double
    Dim myAddonPrice As Double

    Private Sub FormTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click

        MainForm.BringToFront()

        Dim sugarLv = sugarComboBox.Text



        If formTwoProduct.Text = "" Or formTwoQuantity.Text = "" Or comboBoxSize.Text = "" Or comboBoxAddon.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else
            If ContainsInvalidChars(formTwoProduct.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            ' Validate smallPricePI: Check if it's a valid numeric value
            If Not IsNumeric(formTwoQuantity.Text) Then
                MsgBox("Quantity should be a valid numeric value.")
                Return
            End If

            connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"

            GetProductPriceFromDatabase()
            GetAddonPriceFromDatabase()

            Dim addon = comboBoxAddon.Text
            Dim Size = comboBoxSize.Text
            Dim quantity As Double
            Dim variantVar As String = formTwoProduct.Text

            quantity = CDbl(formTwoQuantity.Text)

            Try
                connection.Open()
                query = "INSERT INTO cart (Variant, Size, SugarLevel, Price, Addon, AddonName, Quantity, Total) VALUES (@Variant, @Size, @SugarLevel, @Price, @Addon, @AddonName, @Quantity, ((@Price * @Quantity) + (@Addon * @Quantity)))"
                cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Variant", variantVar)
                cmd.Parameters.AddWithValue("@Size", Size)
                cmd.Parameters.AddWithValue("@Price", myPrice)
                cmd.Parameters.AddWithValue("@Addon", myAddonPrice)
                cmd.Parameters.AddWithValue("@AddonName", addon)
                cmd.Parameters.AddWithValue("@Quantity", quantity)
                cmd.Parameters.AddWithValue("@SugarLevel", sugarLv)

                cmd.ExecuteNonQuery()

                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            BuyForm.GetTotalQty()
            BuyForm.GetTotalLabel()
            UpdateCart()
            Me.Hide()
            MainForm.BringToFront()
        End If
    End Sub

    Public Sub GetProductPriceFromDatabase()
        Dim mySize As String = comboBoxSize.Text.Trim()

        Dim query As String = "SELECT price AS priceFinal FROM size WHERE sizeName = @size"

        Using connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@size", mySize)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            myPrice = CDbl(reader("priceFinal"))
                        Else
                            MessageBox.Show("Price not found for the selected size.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Public Sub GetAddonPriceFromDatabase()
        Dim myAddOn As String = comboBoxAddon.Text.Trim()

        Dim query As String = "SELECT price AS priceFinal FROM addons WHERE addOnsName = @addOnsName"

        Using connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@addOnsName", myAddOn)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            myAddonPrice = CDbl(reader("priceFinal"))
                        Else
                            MessageBox.Show("Price not found for the selected size.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class