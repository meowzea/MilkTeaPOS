Imports System.Security.Cryptography.X509Certificates

Public Class AddOnsStock
    Dim selectedID As Integer
    Public Sub New(id As Integer, name As String, stocks As Integer)
        ' Constructor to accept the values as parameters and set them
        InitializeComponent()

        ' Set the values in the controls of the other form, or store them as needed
        selectedID = id
        addOnsStockName.Text = name
        addOnsStockAmount.Text = stocks
    End Sub
    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        If addOnsStockName.Text = "" Or addOnsStockAmount.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else
            If ContainsInvalidChars(addOnsStockName.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            ' Validate smallPricePI: Check if it's a valid numeric value
            If Not IsNumeric(addOnsStockAmount.Text) Then
                MsgBox("Price should be a valid numeric value.")
                Return
            End If

            updates("UPDATE addons SET  stocks='" & addOnsStockAmount.Text & "' WHERE addOnsID='" & selectedID & "'")
            InventoryManagement.ReloadInventory()
            addOnsStockName.Text = ""
            addOnsStockAmount.Text = ""
            Me.Hide()
            MainForm.BringToFront()
        End If
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        addOnsStockName.Text = ""
        addOnsStockAmount.Text = ""
        Me.Hide()
        MainForm.BringToFront()
    End Sub
End Class