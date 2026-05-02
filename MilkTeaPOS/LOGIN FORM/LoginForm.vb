Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim userDetermine As Integer
    Dim loggedInAs As String

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            passwordTbox.UseSystemPasswordChar = False
        Else
            passwordTbox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click
        SignUpForm.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        Dim usernameAdmin = "admin"
        Dim passwordAdmin = "1234"
        Dim userInput As String
        Dim passInput As String

        userInput = usernameTbox.Text
        passInput = passwordTbox.Text

        If usernameTbox.Text = "" Or passwordTbox.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else

            If userInput Like usernameAdmin And passInput Like passwordAdmin Then
                MessageBox.Show("Logged In As Administrator")
                Me.Hide()
                userDetermine = 1
                loggedInAs = "Admin"

                Dim newForm1 As New MainForm()

                'pass the value to main form
                newForm1.UserDetermine = userDetermine
                newForm1.LoggedInAs = loggedInAs
                'newForm.OrderID = selectedOrderID
                newForm1.Show()
            ElseIf userInput <> usernameAdmin And passInput <> usernameAdmin Then

                Dim connection = New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
                Dim command As New MySqlCommand("SELECT `username`, `password` FROM `employees` WHERE `username` = @username AND `password` = @password", connection)

                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = usernameTbox.Text
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTbox.Text

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)

                If table.Rows.Count = 0 Then

                    MessageBox.Show("Invalid Username Or Password")

                Else

                    MessageBox.Show("Logged In As Employee")
                    userDetermine = 2

                    connection.Open()

                    Dim query As String = $"SELECT employeeName As employeeNameSelected FROM employees WHERE username = '{userInput}'"

                    Using myConnection As New MySqlConnection("server=localhost;userid=root;password=;database=milktea")
                        Try
                            myConnection.Open()
                            Using myCommand As New MySqlCommand(query, connection)
                                myCommand.Parameters.AddWithValue("@userinput", userInput)
                                Using myReader As MySqlDataReader = myCommand.ExecuteReader()
                                    If myReader.Read() Then
                                        loggedInAs = myReader("employeeNameSelected")
                                    End If
                                End Using
                            End Using
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                    End Using

                    connection.Close()

                    Dim newForm2 As New MainForm()

                    'pass the value to main form
                    newForm2.UserDetermine = userDetermine
                    newForm2.LoggedInAs = loggedInAs
                    'newForm.OrderID = selectedOrderID
                    newForm2.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid Username Or Password")
            End If
        End If
        usernameTbox.Text = ""
        passwordTbox.Text = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameTbox.Text = ""
        passwordTbox.Text = ""
    End Sub
End Class