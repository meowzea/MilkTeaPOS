Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class InventoryManagement
    Dim connection As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Dim result As String

    Dim inventoryDT As New DataTable
    Dim inventoryTable As New MySqlDataAdapter("SELECT productID, Variant, stocks FROM products;", connection)
    Private Sub InventoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        Try
            connection.Open()
            query = "SELECT productID, Variant, stocks FROM products"
            cmd.Connection = connection
            cmd.CommandText = query
            result = cmd.ExecuteNonQuery

            If result = 0 Then
                MessageBox.Show("FAILED TO LOAD PRODUCTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Dim data_adapter As New MySqlDataAdapter(cmd)
            Dim data_table As New DataTable
            data_adapter.Fill(data_table)
            DataGridViewProductInventory.DataSource = data_table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try

        Try
            connection.Open()
            Dim query1 As String = "SELECT addOnsID, addOnsName, stock FROM addons"
            Dim cmd1 As New MySqlCommand(query1, connection)
            Dim result1 As String = cmd1.ExecuteNonQuery()

            If result = 0 Then
                MessageBox.Show("FAILED TO LOAD PRODUCTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim data_adapter As New MySqlDataAdapter(cmd1)
            Dim data_table1 As New DataTable
            data_adapter.Fill(data_table1)
            DataGridViewAddOnsInventory.DataSource = data_table1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLbl.Text = Date.Now.ToString("f")
    End Sub
    Public Sub ReloadInventory()
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        Try
            connection.Open()
            query = "SELECT productID, Variant, stocks FROM products"
            cmd.Connection = connection
            cmd.CommandText = query
            result = cmd.ExecuteNonQuery

            If result = 0 Then
                MessageBox.Show("FAILED TO LOAD PRODUCTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Dim data_adapter As New MySqlDataAdapter(cmd)
            Dim data_table As New DataTable
            data_adapter.Fill(data_table)
            DataGridViewProductInventory.DataSource = data_table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try


        Try
            connection.Open()
            Dim query1 As String = "SELECT addOnsID, addOnsName, stock FROM addons"
            Dim cmd1 As New MySqlCommand(query1, connection)
            Dim result1 As String = cmd1.ExecuteNonQuery()

            If result = 0 Then
                MessageBox.Show("FAILED TO LOAD PRODUCTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim data_adapter As New MySqlDataAdapter(cmd1)
            Dim data_table1 As New DataTable
            data_adapter.Fill(data_table1)
            DataGridViewAddOnsInventory.DataSource = data_table1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try

        inventoryDT.Clear()
        inventoryTable.Fill(inventoryDT)
        DataGridViewProductInventory.DataSource = inventoryDT
    End Sub

    Private Sub DataGridViewProductInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductInventory.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedID As Integer = DataGridViewProductInventory.Rows(e.RowIndex).Cells(1).Value
            Dim selectedName As String = DataGridViewProductInventory.Rows(e.RowIndex).Cells(2).Value
            Dim selectedStock As Integer = DataGridViewProductInventory.Rows(e.RowIndex).Cells(3).Value

            Dim ProductStock As New ProductStock(selectedID, selectedName, selectedStock)
            ProductStock.Show()
        End If
    End Sub

    Private Sub DataGridViewAddOnsInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAddOnsInventory.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedID As Integer = DataGridViewAddOnsInventory.Rows(e.RowIndex).Cells(1).Value
            Dim selectedName As String = DataGridViewAddOnsInventory.Rows(e.RowIndex).Cells(2).Value
            Dim selectedStock As Integer = DataGridViewAddOnsInventory.Rows(e.RowIndex).Cells(3).Value

            Dim AddOnsStock As New AddOnsStock(selectedID, selectedName, selectedStock)
            AddOnsStock.Show()
        End If
    End Sub

    Private Sub searchTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchTxtBox.TextChanged
        Dim DV As New DataView(inventoryDT)
        DV.RowFilter = String.Format("Variant Like '%{0}%'", searchTxtBox.Text)
        DataGridViewProductInventory.DataSource = DV
    End Sub
End Class