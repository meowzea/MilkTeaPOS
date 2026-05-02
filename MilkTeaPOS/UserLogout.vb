Public Class UserLogout

    Public Property LoggedInAs() As String

    Private Sub UserLogout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentUserLbl.Text = LoggedInAs()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        If MsgBox("Do you want to logout?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            Me.Dispose()
            MainForm.Dispose()
            LoginForm.Show()
        End If
    End Sub

    Private Sub UserLogout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainForm.BringToFront()
    End Sub
End Class