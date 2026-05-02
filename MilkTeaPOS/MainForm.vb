Imports MySql.Data.MySqlClient
Public Class MainForm

    Public Property UserDetermine() As Integer
    Public Property LoggedInAs() As String


    Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")


    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        switchDashboard(BuyForm)
        BuyForm.ReloadTables()
    End Sub

    Sub switchDashboard(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        panel.FormBorderStyle = FormBorderStyle.None
        Panel2.Controls.Add(panel)
        Panel2.Tag = panel
        panel.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"
        Dim Reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String
            query = "DELETE from milktea.cart"
            Dim command As New MySqlCommand(query, connection)
            Reader = command.ExecuteReader
            BuyForm.ResetIncrement()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Application.Exit()
    End Sub

    Private Sub editProductBtn_Click(sender As Object, e As EventArgs) Handles editProductBtn.Click
        switchDashboard(ProductInventory)
        ProductInventory.ReloadTables()
    End Sub

    Private Sub manageProductBtn_Click(sender As Object, e As EventArgs) Handles manageProductBtn.Click
        switchDashboard(InventoryManagement)
        InventoryManagement.ReloadInventory()

    End Sub

    Private Sub recentBtn_Click(sender As Object, e As EventArgs) Handles recentBtn.Click
        switchDashboard(TransactionLogs)
        TransactionLogs.ReloadTables()
    End Sub

    Private Sub analyticsBtn_Click(sender As Object, e As EventArgs) Handles analyticsBtn.Click
        switchDashboard(RecentForm)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserDetermine() = 1 Then
            buyBtn.Show()
            editProductBtn.Show()
            manageProductBtn.Show()
            recentBtn.Show()
            analyticsBtn.Show()
        ElseIf UserDetermine() = 2 Then
            buyBtn.Show()
            editProductBtn.Hide()
            manageProductBtn.Hide()
            recentBtn.Show()
            analyticsBtn.Show()
        End If
    End Sub

    Private Sub accountBtn_Click(sender As Object, e As EventArgs) Handles accountBtn.Click
        Dim newUserLogout As New UserLogout()

        newUserLogout.LoggedInAs = LoggedInAs
        newUserLogout.Show()
    End Sub
End Class
