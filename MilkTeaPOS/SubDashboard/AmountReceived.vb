Public Class AmountReceived
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        Me.Dispose()
        BuyForm.PayButtonNext()
        MainForm.BringToFront()
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        Me.Dispose()
        MainForm.BringToFront()
    End Sub
End Class