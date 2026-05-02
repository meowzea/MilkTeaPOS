Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class ProductInventory
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
    Dim cmd As New MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Dim result As String
    Dim productDT As New DataTable
    Dim productTable As New MySqlDataAdapter("SELECT productID, Variant, smallPrice, largePrice FROM products;", connection)

    Private Sub ProductInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ReloadTables()

    End Sub

    Public Sub ReloadTables()

        Try
            connection.Open()
            query = "SELECT productID, Variant, smallPrice, largePrice FROM products"
            cmd.Connection = connection
            cmd.CommandText = query
            result = cmd.ExecuteNonQuery

            If result = 0 Then
                MessageBox.Show("FAILED TO LOAD PRODUCTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Dim data_adapter As New MySqlDataAdapter(cmd)
            Dim data_table As New DataTable
            data_adapter.Fill(data_table)
            DataGridViewProductManagement.DataSource = data_table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try

        Try
            connection.Open()
            Dim query1 As String = "SELECT addOnsID, addOnsName, price FROM addons"
            Dim cmd1 As New MySqlCommand(query1, connection)
            Dim result1 As String = cmd1.ExecuteNonQuery()

            If result = 0 Then
                MessageBox.Show("FAILED TO LOAD PRODUCTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim data_adapter As New MySqlDataAdapter(cmd1)
            Dim data_table1 As New DataTable
            data_adapter.Fill(data_table1)
            DataGridViewAddOns.DataSource = data_table1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try
        productDT.Clear()
        productTable.Fill(productDT)
        DataGridViewProductManagement.DataSource = productDT
    End Sub

    Private Sub addProductBtn_Click(sender As Object, e As EventArgs) Handles addProductBtn.Click
        CreateProduct.Show()
    End Sub

    Public Sub reloadInventory()
        ReloadTables()
        reload("select productid, variant, smallprice, largeprice from products", DataGridViewProductManagement)
    End Sub

    Private Sub addOnsBtn_Click(sender As Object, e As EventArgs) Handles addOnsBtn.Click
        CreateAddons.Show()
    End Sub

    Private Sub DataGridViewProductManagement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductManagement.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedID As Integer = DataGridViewProductManagement.Rows(e.RowIndex).Cells(2).Value
            Dim selectedName As String = DataGridViewProductManagement.Rows(e.RowIndex).Cells(3).Value
            Dim selectedSmallPrice As Integer = DataGridViewProductManagement.Rows(e.RowIndex).Cells(4).Value
            Dim selectedLargePrice As Integer = DataGridViewProductManagement.Rows(e.RowIndex).Cells(5).Value

            Dim EditProductInformation As New EditProductInformation(selectedID, selectedName, selectedSmallPrice, selectedLargePrice)
            EditProductInformation.Show()
        End If

        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then 'delete

            Try
                connection.Open()
                Dim query As String
                query = "DELETE from milktea.products where productID='" & DataGridViewProductManagement.Rows(e.RowIndex).Cells(2).Value & "'"
                Dim command As New MySqlCommand(query, connection)
                Reader = command.ExecuteReader()
                MessageBox.Show("Data Deleted")
                connection.Close()
                'resetIncrement("products", "productID")
                ReloadTables()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()

            End Try
            AddProductForm.ReloadAddonComBox()
            EditProductForm.ReloadAddonComBox()
        End If

    End Sub

    Private Sub DataGridViewAddOns_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAddOns.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedID As Integer = DataGridViewAddOns.Rows(e.RowIndex).Cells(2).Value
            Dim selectedName As String = DataGridViewAddOns.Rows(e.RowIndex).Cells(3).Value
            Dim selectedPrice As Integer = DataGridViewAddOns.Rows(e.RowIndex).Cells(4).Value


            Dim EditAddOnsInformation As New EditAddOnsInformation(selectedID, selectedName, selectedPrice)
            EditAddOnsInformation.Show()
        End If

        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then 'delete

            Try
                connection.Open()
                Dim query As String
                query = "DELETE from milktea.addons where addOnsID='" & DataGridViewAddOns.Rows(e.RowIndex).Cells(2).Value & "'"
                Dim command As New MySqlCommand(query, connection)
                Reader = command.ExecuteReader()

                MessageBox.Show("Data Deleted")
                connection.Close()
                ReloadTables()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

            AddProductForm.ReloadAddonComBox()
            EditProductForm.ReloadAddonComBox()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLbl.Text = Date.Now.ToString("f")
    End Sub


    Private Sub searchTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchTxtBox.TextChanged
        Dim DV As New DataView(productDT)
        DV.RowFilter = String.Format("Variant Like '%{0}%'", searchTxtBox.Text)
        DataGridViewProductManagement.DataSource = DV
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

End Class