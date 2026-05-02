Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class BuyForm

    Dim productValue As String
    Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
    Dim cmd As New MySqlCommand
    Dim productDT As New DataTable
    Dim cartDT As New DataTable
    Dim productTable As New MySqlDataAdapter("SELECT Variant, largePrice, SmallPrice FROM products;", connection)
    Dim cartTable As New MySqlDataAdapter("SELECT OrderID ,Variant, Size, SugarLevel,Price, Quantity, Addon, AddonName,  Total FROM cart;", connection)
    Dim query2 As String
    Dim Reader As MySqlDataReader
    Dim myTotal As Double

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Dim cellValue As Object

    Public Sub GetTotalLabel()

        Dim query As String = "SELECT SUM(Total) As TotalPrice FROM milktea.cart;"

        Using connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            myTotal = CDbl(reader("TotalPrice"))
                        Else
                            MessageBox.Show("Price not found for the selected size.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        totalLbl.Text = myTotal
    End Sub

    Dim totalQty As Double

    Public Sub GetTotalQty()

        Dim query As String = "SELECT SUM(Quantity) As TotalQty FROM milktea.cart;"

        Using connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            totalQty = CDbl(reader("TotalQty"))
                        Else
                            MessageBox.Show("Price not found for the selected size.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        qtyLbl.Text = totalQty
    End Sub

    Public Sub ProductLoad()
        productDT.Clear() 'bagong add
        productTable.Fill(productDT)

        DataGridViewProducts.DataSource = productDT
        DataGridViewProducts.Columns("Column3").DisplayIndex = 3
    End Sub

    Public Sub CartLoad()

        cartDT.Clear()
        cartTable.Fill(cartDT)

        DataGridViewCart.DataSource = cartDT

        'cartTable.Dispose()

        DataGridViewCart.Columns("column1").DisplayIndex = 10
        DataGridViewCart.Columns("column2").DisplayIndex = 10
    End Sub

    Public Sub ReloadTables()
        ProductLoad()
        CartLoad()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProductLoad()
        CartLoad()
        Timer1.Enabled = True
        DataGridViewProducts.AutoResizeColumns()
        DataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCart.AutoResizeColumns()
        DataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub DataGridViewProducts_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProducts.CellContentClick
        'eto code ng button sa datagridviewProducts
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then 'select

            'to get selected product
            Dim selectedCellValue As Object = DataGridViewProducts.Rows(e.RowIndex).Cells(1).Value

            productValue = selectedCellValue.ToString()

            Dim form2Instance As New AddProductForm()

            'pass the value to form2
            form2Instance.ReceivedProductValue = productValue
            form2Instance.Show()
        End If
    End Sub

    Private Sub searchTxtBox_TextChanged_1(sender As Object, e As EventArgs) Handles searchTxtBox.TextChanged
        'search function for products
        Dim DV As New DataView(productDT)
        DV.RowFilter = String.Format("Variant Like '%{0}%'", searchTxtBox.Text)
        DataGridViewProducts.DataSource = DV
    End Sub

    Dim selectedOrderID As Integer

    Private Sub DataGridViewCart_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCart.CellContentClick

        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"

        'eto naman sa cart pansin mo dalawa if statement kasi dalawa rin button
        'ini specify ko alin column yung edit and select button
        'si select 0 column (nasa dulo lang sya kasi inusog ko sa display tignan mo sa cartLoad method,
        'pero orig columnValue ni delete eh 1 and si edit is 0)

        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then 'edit

            'to get selected product
            Dim selectedCellValue As Object = DataGridViewCart.Rows(e.RowIndex).Cells(3).Value
            Dim selectedCellOrderID As Object = DataGridViewCart.Rows(e.RowIndex).Cells(2).Value

            productValue = selectedCellValue.ToString()
            selectedOrderID = selectedCellOrderID

            Dim editProductForm As New EditProductForm()

            'pass the value to form2
            editProductForm.EditProductValue = productValue
            editProductForm.OrderID = selectedOrderID
            editProductForm.Show()
        End If
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then 'delete

            Try
                If MsgBox("Delete Order?", MsgBoxStyle.YesNo, "Delete Message") = MsgBoxResult.Yes Then
                    connection.Open()
                    Dim query As String
                    query = "DELETE from milktea.cart where OrderID='" & DataGridViewCart.Rows(e.RowIndex).Cells(2).Value & "'"
                    Dim command As New MySqlCommand(query, connection)
                    Reader = command.ExecuteReader
                    MessageBox.Show("Order Deleted")

                    connection.Close()

                    connection.Open()

                    Dim connectionString As String = "server=localhost;userid=root;password=;database=milktea"
                    Dim tableName As String = "milktea.cart"

                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        Dim query1 As String = $"SELECT COUNT(*) FROM {tableName}"
                        Using command1 As New MySqlCommand(query1, connection)
                            Dim rowCount As Integer = CInt(command1.ExecuteScalar())

                            If rowCount > 0 Then
                                GetTotalLabel()
                                GetTotalQty()
                            Else
                                totalLbl.Text = "0"
                                qtyLbl.Text = "0"
                            End If
                        End Using
                    End Using

                    connection.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If

        If DataGridViewCart.Rows.Count > 0 Then
            ' Get the last row
            Dim lastRowIndex As Integer = DataGridViewCart.Rows.Count - 1

            ' Access the first column in the last row and get its value
            cellValue = DataGridViewCart.Rows(lastRowIndex).Cells(2).Value

        End If

        CartLoad()
        ResetIncrement()
    End Sub

    Public Sub ResetExistingIncrement()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"

        Try
            connection.Open()
            Dim queryA = "SET @num := 0;UPDATE cart SET OrderID = @num := (@num+1);ALTER TABLE cart AUTO_INCREMENT = 1;"

            Dim command1 As New MySqlCommand(queryA, connection)
            Reader = command1.ExecuteReader

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try


    End Sub

    Public Sub ResetIncrement()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        connection.Open()

        query2 = "ALTER TABLE cart AUTO_INCREMENT = 1;"
        Dim command1 As New MySqlCommand(query2, connection)
        Reader = command1.ExecuteReader
        connection.Close()
    End Sub

    Public Sub ResetOrdersIncrement()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        connection.Open()

        query2 = "ALTER TABLE orders AUTO_INCREMENT = 1;"
        Dim command1 As New MySqlCommand(query2, connection)
        Reader = command1.ExecuteReader
        connection.Close()
    End Sub

    Private Sub cancelBtn_Click_1(sender As Object, e As EventArgs) Handles cancelBtn.Click
        If DataGridViewCart.Rows.Count > 0 Then
            Try
                If MsgBox("Delete Cart?", MsgBoxStyle.YesNo, "Delete Message") = MsgBoxResult.Yes Then
                    DeleteCart()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If

        CartLoad()
    End Sub

    Public Sub DeleteCart()
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        Dim Reader As MySqlDataReader

        If DataGridViewCart.Rows.Count > 0 Then
            Try
                connection.Open()
                Dim query As String
                query = "DELETE from milktea.cart"
                Dim command As New MySqlCommand(query, connection)
                Reader = command.ExecuteReader
                connection.Close()
                ResetIncrement()

                connection.Open()

                Dim connectionString As String = "server=localhost;userid=root;password=;database=milktea"
                Dim tableName As String = "milktea.cart"

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query1 As String = $"SELECT COUNT(*) FROM {tableName}"
                    Using command1 As New MySqlCommand(query1, connection)
                        Dim rowCount As Integer = CInt(command1.ExecuteScalar())
                        If rowCount > 0 Then
                            GetTotalLabel()
                            GetTotalQty()
                        Else
                            totalLbl.Text = "0"
                            qtyLbl.Text = "0"
                        End If
                    End Using
                End Using

                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLbl.Text = Date.Now.ToString("f")
    End Sub

    Private Sub payBtn_Click(sender As Object, e As EventArgs) Handles payBtn.Click
        AmountReceived.Show()
    End Sub

    Public Sub PayButtonNext()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"

        Try
            If DataGridViewCart.Rows.Count > 0 Then
                If MsgBox("Confirm Order?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    connection.Open()
                    Dim query As String
                    Dim result As Integer
                    query = "INSERT INTO receipt (totalAmount,date) VALUES ('" & totalLbl.Text & "', NOW())"
                    Dim command As New MySqlCommand(query, connection)
                    command.ExecuteNonQuery()

                    query = "SELECT COUNT(receiptID) from receipt"
                    Dim command3 As New MySqlCommand(query, connection)
                    result = command3.ExecuteScalar()

                    query = "INSERT INTO orders (receiptID, Variant, Size, Price, Addon, AddonName, Quantity, Total, `Date`) SELECT @receiptID, Variant, Size, Price, Addon, AddonName, Quantity,Total, NOW() FROM cart"
                    Dim command1 As New MySqlCommand(query, connection)
                    command1.Parameters.AddWithValue("@receiptID", result)
                    command1.ExecuteNonQuery()
                    connection.Close()
                    For row As Integer = 0 To DataGridViewCart.RowCount - 1
                        Dim quantity As Integer
                        Dim product As String

                        ' Retrieve quantity and product information from DataGridViewCart
                        quantity = Convert.ToInt32(DataGridViewCart.Rows(row).Cells(6).Value)
                        product = DataGridViewCart.Rows(row).Cells(3).Value.ToString()

                        ' Use parameters in the SQL query to avoid SQL injection
                        Dim query2 As String = "UPDATE products SET stocks = stocks - @quantity WHERE variant = @product"

                        Try
                            Using connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
                                connection.Open()

                                Using cmd As New MySqlCommand(query2, connection)
                                    cmd.Parameters.AddWithValue("@quantity", quantity)
                                    cmd.Parameters.AddWithValue("@product", product)
                                    cmd.ExecuteNonQuery()
                                End Using

                                connection.Close()
                            End Using
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Next

                    MessageBox.Show("Order Confirmed!")
                    changelongpaper()
                    PPD.Document = PD
                    PPD.ShowDialog()

                    DeleteCart()


                    ReloadTables()
                    RecentForm.ProductLoad()
                Else
                    AmountReceived.Show()
                End If
            Else
                MsgBox("The cart is empty. Please add items before confirming the order.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub PanelForm3_Paint(sender As Object, e As PaintEventArgs) Handles PanelForm3.Paint

    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridViewCart.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Courier New", 8, FontStyle.Regular)
        Dim f10 As New Font("Courier New", 10, FontStyle.Regular)
        Dim f10b As New Font("Courier New", 10, FontStyle.Bold)
        Dim f14 As New Font("Courier New", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"
        e.Graphics.DrawString("MilkTea POS", f14, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Biglang Awa St.", f10, Brushes.Black, centermargin, 60, center)
        e.Graphics.DrawString("Tel +1763545473", f10, Brushes.Black, centermargin, 70, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString("DRW8555RE", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 95)
        e.Graphics.DrawString("Steve Jobs", f8, Brushes.Black, 70, 95)

        e.Graphics.DrawString("08/17/2021 | 15.34", f8, Brushes.Black, 0, 105)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 125)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 40, 125)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 180, 125, right)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin, 125, right)
        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 135)

        Dim height As Integer 'DGV Position
        Dim i As Long
        DataGridViewCart.AllowUserToAddRows = False


        For row As Integer = 0 To DataGridViewCart.RowCount - 1
            height += 30
            e.Graphics.DrawString(DataGridViewCart.Rows(row).Cells(7).Value.ToString, f8, Brushes.Black, 0, 140 + height)
            e.Graphics.DrawString(DataGridViewCart.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 40, 140 + height)

            e.Graphics.DrawString(DataGridViewCart.Rows(row).Cells(9).Value.ToString, f8, Brushes.Black, 40, 150 + height) ' addon name
            e.Graphics.DrawString($"SGR {DataGridViewCart.Rows(row).Cells(5).Value.ToString}", f8, Brushes.Black, 40, 160 + height) 'sugar

            i = DataGridViewCart.Rows(row).Cells(2).Value
            DataGridViewCart.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridViewCart.Rows(row).Cells(6).Value.ToString, f8, Brushes.Black, 180, 140 + height, right)
            e.Graphics.DrawString(DataGridViewCart.Rows(row).Cells(8).Value.ToString, f8, Brushes.Black, 165, 150 + height) ' addon price


            'totalprice
            Dim totalprice As Long
            totalprice = Val(DataGridViewCart.Rows(row).Cells(10).Value)

            e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, 140 + height, right)



        Next
        'End If

        Dim height2 As Integer
        height2 = 145 + height
        sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 25 + height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 30 + height2, right)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 30 + height2)


        e.Graphics.DrawString("~ Thanks for stopping by! ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        e.Graphics.DrawString("~ MilkTea POS ~", f10, Brushes.Black, centermargin, 85 + height2, center)

    End Sub

    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridViewCart.RowCount - 1
            countprice = countprice + Val(DataGridViewCart.Rows(rowitem).Cells(10).Value)
        Next
        t_price = countprice
        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridViewCart.RowCount - 1
            countqty = countqty + DataGridViewCart.Rows(rowitem).Cells(7).Value
        Next
        t_qty = countqty
    End Sub

End Class