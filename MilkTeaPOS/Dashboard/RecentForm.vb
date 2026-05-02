Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Public Class RecentForm
    Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
    Dim recentDT As New DataTable
    Dim recentTable As New MySqlDataAdapter("SELECT * FROM orders;", connection)

    Dim cellValue As Object

    Public Sub ProductLoad()
        recentDT.Clear()
        recentTable.Fill(recentDT)

        dgvRecentOrders.DataSource = recentDT
    End Sub

    Private Sub RecentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductLoad()
        dgvRecentOrders.AutoResizeColumns()
        dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Sub ResetIncrement()
        Dim query2 As String
        Dim Reader As MySqlDataReader

        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        connection.Open()

        query2 = "ALTER TABLE orders AUTO_INCREMENT = 1;"
        Dim command1 As New MySqlCommand(query2, connection)
        Reader = command1.ExecuteReader
        connection.Close()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        Dim Reader As MySqlDataReader

        Try
            If MsgBox("Delete Recent Orders?", MsgBoxStyle.YesNoCancel, "Delete") = MsgBoxResult.Yes Then
                connection.Open()
                Dim query As String
                query = "DELETE from milktea.orders"
                Dim command As New MySqlCommand(query, connection)
                Reader = command.ExecuteReader
                BuyForm.ResetOrdersIncrement()
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        ResetIncrement()
        ProductLoad()
    End Sub

    Private Sub searchByDateBtn_Click(sender As Object, e As EventArgs)

        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM orders WHERE `Date` BETWEEN @d1 AND @d2", connection)

        command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
        command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

        Dim adapter As New MySqlDataAdapter(command)

        adapter.Fill(table)

        dgvRecentOrders.DataSource = table

    End Sub

    Public Sub SearchByTime()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM orders WHERE `Date` BETWEEN @d1 AND @d2", connection)

        command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
        command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

        Dim adapter As New MySqlDataAdapter(command)

        adapter.Fill(table)

        dgvRecentOrders.DataSource = table
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

        SearchByTime()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        SearchByTime()

    End Sub

    Private Sub resetSearch_Click(sender As Object, e As EventArgs) Handles resetSearch.Click
        DateTimePicker1.Value = DateTime.Today
        DateTimePicker2.Value = DateTime.Today
        ProductLoad()
    End Sub
End Class