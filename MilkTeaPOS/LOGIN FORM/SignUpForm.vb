Imports FontAwesome.Sharp
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class SignUpForm

    Dim connection As New MySqlConnection("server=localhost;userid=root;password='';database=milktea")
    Dim query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Dim charactersAllowed As String = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        LoginForm.Show()
        Me.Hide()
        LoginForm.BringToFront()
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        If nameTbox.Text = "" Or usernameTbox.Text = "" Or passwordTbox.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else

            If passwordTbox.Text <> passRetype.Text Then
                MsgBox("Password does not match!")
                Return
            End If



            Dim employeeName = nameTbox.Text
            Dim username = usernameTbox.Text
            Dim password = passwordTbox.Text



            connection.ConnectionString = "server=localhost;userid=root;password=;database=milktea"

            Try
                If MsgBox("Confirm", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    connection.Open()
                    query = "INSERT INTO employees (employeeName, username, password) VALUES (@employeeName, @username, @password)"
                    cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@employeeName", employeeName)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.ExecuteNonQuery()

                    connection.Close()
                End If
            Catch ex As Exception
                MsgBox("Username not available.")
                Return
            Finally
                connection.Dispose()
            End Try

            Me.Close()
        End If
        LoginForm.BringToFront()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            passwordTbox.UseSystemPasswordChar = False
            passRetype.UseSystemPasswordChar = False
        Else
            passwordTbox.UseSystemPasswordChar = True
            passRetype.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub usernameTbox_TextChanged(sender As Object, e As EventArgs) Handles usernameTbox.TextChanged
        Timer1.Enabled = True
        Timer1.Interval = 500
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Rectangle 7.png")
        PictureBox1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 500 Then
            connection = New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
            Dim query As String = "SELECT username FROM employees where username=@username"
            connection.Open()
            cmd = New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", usernameTbox.Text)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                Label6.BackColor = Color.Red
                Label6.ForeColor = Color.White
                PictureBox1.Visible = False
                Label6.Text = "username unavailable"
                connection.Close()
                Exit Sub
            End While
            Label6.Text = "username available"
            Label6.BackColor = Color.Green
            Label6.ForeColor = Color.White
            PictureBox1.Visible = False
            connection.Close()
        End If
        Timer1.Interval += 1000
    End Sub

    Private Sub nameTbox_TextChanged(sender As Object, e As EventArgs) Handles nameTbox.TextChanged
        Dim theText As String = nameTbox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = nameTbox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To nameTbox.Text.Length - 1
            Letter = nameTbox.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        nameTbox.Text = theText
        nameTbox.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameTbox.Text = ""
        passwordTbox.Text = ""
        nameTbox.Text = ""
        passRetype.Text = ""
    End Sub
End Class