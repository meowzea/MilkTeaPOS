Imports System.Windows.Controls
Imports MySql.Data.MySqlClient

Public Class TransactionLogs
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
    Dim cmd As New MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Dim result As String
    Dim totalSales As Integer
    Dim totalQuantitySold As Integer
    Dim ordersDT As New DataTable
    Dim ordersTable As New MySqlDataAdapter("SELECT * FROM orders;", connection)

    Private Sub ProductInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ReloadTables()
    End Sub

    Public Sub ReloadSales()
        totalSales = 0
        For row As Integer = 0 To dtgReceipt.RowCount - 1
            Dim sale As Integer
            ' Retrieve quantity and product information from DataGridViewCart
            sale = Convert.ToInt32(dtgReceipt.Rows(row).Cells(1).Value)
            totalSales += sale
        Next
        totalLbl.Text = totalSales.ToString()
    End Sub

    Public Sub ReloadQuantitySold()
        totalQuantitySold = 0
        For row As Integer = 0 To dtgTransactionLogs.RowCount - 1
            Dim sale As Integer
            ' Retrieve quantity and product information from DataGridViewCart
            sale = Convert.ToInt32(dtgTransactionLogs.Rows(row).Cells(5).Value)
            totalQuantitySold += sale
        Next
        quantitySold.Text = totalQuantitySold.ToString()
    End Sub

    Public Sub ReloadTables()

        Try
            connection.Open()
            query = "SELECT * FROM orders"
            cmd.Connection = connection
            cmd.CommandText = query
            result = cmd.ExecuteNonQuery

            Dim data_adapter As New MySqlDataAdapter(cmd)
            Dim data_table As New DataTable
            data_adapter.Fill(data_table)
            dtgTransactionLogs.DataSource = data_table
            dtgTransactionLogs.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128)
            dtgTransactionLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128)
            dtgTransactionLogs.EnableHeadersVisualStyles = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try

        Try
            connection.Open()
            query = "SELECT * FROM receipt"
            cmd.Connection = connection
            cmd.CommandText = query
            result = cmd.ExecuteNonQuery

            Dim data_adapter As New MySqlDataAdapter(cmd)
            Dim data_table As New DataTable
            data_adapter.Fill(data_table)
            dtgReceipt.DataSource = data_table
            dtgReceipt.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128)
            dtgReceipt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128)
            dtgReceipt.EnableHeadersVisualStyles = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            data_adapter.Dispose()
            connection.Close()
        End Try

        ordersDT.Clear()
        ordersTable.Fill(ordersDT)
        dtgTransactionLogs.DataSource = ordersDT
        ReloadSales()
        ReloadQuantitySold()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLbl.Text = Date.Now.ToString("f")
    End Sub

    Private Sub TransactionLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub searchTxtBox_TextChanged(sender As Object, e As EventArgs) Handles searchTxtBox.TextChanged
        Dim DV As New DataView(ordersDT)
        If Integer.TryParse(searchTxtBox.Text, Nothing) Then
            ' Assuming ReceiptID is a numeric column, remove the single quotes
            DV.RowFilter = String.Format("ReceiptID = {0}", searchTxtBox.Text)
        Else
            ' If the entered text is not a valid integer, show all rows
            DV.RowFilter = ""
        End If
        dtgTransactionLogs.DataSource = DV
    End Sub

    Private Sub dtgReceipt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgReceipt.CellContentClick

    End Sub
End Class