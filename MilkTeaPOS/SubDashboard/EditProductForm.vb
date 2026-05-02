Imports MySql.Data.MySqlClient

Public Class EditProductForm

    Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
    Dim query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Dim myPrice As Double
    Dim myAddonPrice As Double
    Public Property EditProductValue() As String
    Public Property OrderID() As Integer

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
        Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
        Dim adapter As New MySqlDataAdapter("SELECT addOnsName FROM addons;", connection)
        Dim table As New DataTable

        adapter.Fill(table)

        comboBoxAddon.DataSource = table
        comboBoxAddon1.DataSource = table
        comboBoxAddon2.DataSource = table

        comboBoxAddon.ValueMember = ""
        comboBoxAddon.DisplayMember = "addOnsName"
        comboBoxAddon1.ValueMember = ""
        comboBoxAddon1.DisplayMember = "addOnsName"
        comboBoxAddon2.ValueMember = ""
        comboBoxAddon2.DisplayMember = "addOnsName"
    End Sub

    Private Sub EditProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadAddonComBox()
        ReloadSizeComBox()
        editProduct.Text = EditProductValue()
        editProduct.ReadOnly = True
        editProduct.Enabled = False
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        Me.Close()
        MainForm.BringToFront()
    End Sub



    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click

        If editProduct.Text = "" Or formTwoQuantity.Text = "" Or comboBoxSize.Text = "" Or comboBoxAddon.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else
            If ContainsInvalidChars(editProduct.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            ' Validate smallPricePI: Check if it's a valid numeric value
            If Not IsNumeric(formTwoQuantity.Text) Then
                MsgBox("Quantity should be a valid numeric value.")
                Return
            End If

            GetProductPriceFromDatabase()
            GetAddonPriceFromDatabase()

            Dim addonName = comboBoxAddon.Text

            Dim quantityInt As Double = CDbl(formTwoQuantity.Text)

            Dim totalPrice As Double = ((myPrice * quantityInt) + myAddonPrice)

            Try
                connection.Open()
                query = "UPDATE milktea.cart SET `Quantity` = '" & formTwoQuantity.Text & "', `Size` = '" & comboBoxSize.Text & "', `SugarLevel` = '" & sugarComboBox.Text & "' , `Price` = '" & myPrice & "', `Addon` = '" & myAddonPrice & "', `AddonName` = '" & addonName & "', `Total` = '" & totalPrice & "' WHERE `OrderID` = @tempVar"
                cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@tempVar", OrderID())


                cmd.ExecuteNonQuery()

                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            BuyForm.GetTotalQty()
            BuyForm.GetTotalLabel()
            AddProductForm.UpdateCart()
            Me.Hide()
            MainForm.BringToFront()
        End If
        MainForm.BringToFront()

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