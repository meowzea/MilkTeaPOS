Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Module SQL
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=milktea")
    End Function

    Public connection As MySqlConnection = strconnection()
    Public cmd As New MySqlCommand
    Public data_adapter As New MySqlDataAdapter
    Public data_table As New DataTable
    Public query As String
    Public result As String
    Public Sub createVariant(ByVal sql As String)
        Try
            connection.Open()
            query = sql
            cmd.Connection = connection
            cmd.CommandText = query
            result = cmd.ExecuteNonQuery

            'If result = 0 Then
            '    MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    MessageBox.Show("DATA HAS BEEN SAVED IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByRef DTG As Object)
        Try
            data_table = New DataTable
            connection.Open()
            cmd.Connection = connection
            cmd.CommandText = sql
            data_adapter.SelectCommand = cmd
            data_adapter.Fill(data_table)
            DTG.datasource = data_table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
            data_adapter.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            connection.Open()
            cmd.Connection = connection
            cmd.CommandText = sql

            result = cmd.ExecuteNonQuery
            'If result = 0 Then
            '    MessageBox.Show("FAILED TO UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    MessageBox.Show("UPDATE HAS BEEN SAVED IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()

        End Try
    End Sub

    Public Sub resetIncrement(ByVal table As String, ByVal column As String)
        Dim Reader As MySqlDataReader
        Try
            connection.Open()

            ' Set @num variable to 0
            query = "SET @num := 0;UPDATE " & table & " SET " & column & " = @num := (@num + 1);"
            Dim command1 As New MySqlCommand(query, connection)
            Reader = command1.ExecuteReader()

            ' Close the reader before executing the next query
            Reader.Close()

            ' Reset the auto-increment value
            query = "ALTER TABLE " & table & " AUTO_INCREMENT = 1;"
            Dim command2 As New MySqlCommand(query, connection)
            command2.ExecuteNonQuery()

            connection.Close()

            'cmd.CommandText = query
            'cmd.ExecuteNonQuery()

            '' Update the column with sequential values
            'query = "UPDATE " & table & " SET " & column & " = @num := (@num + 1);"
            'cmd.CommandText = query
            'cmd.ExecuteNonQuery()

            '' Reset the auto-increment
            'query = "ALTER TABLE " & table & " AUTO_INCREMENT = 1;"
            'cmd.CommandText = query
            'cmd.ExecuteNonQuery()

            MessageBox.Show("AUTO_INCREMENT HAS BEEN RESET IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Fatal Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function ContainsInvalidChars(input As String) As Boolean
        For Each c As Char In input
            If Char.IsDigit(c) Or Not Char.IsLetterOrDigit(c) Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
