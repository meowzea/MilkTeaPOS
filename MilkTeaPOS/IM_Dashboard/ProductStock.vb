Public Class ProductStock
    Dim selectedID As Integer

    Public Sub New(id As Integer, name As String, stocks As Integer)
        ' Constructor to accept the values as parameters and set them
        InitializeComponent()

        ' Set the values in the controls of the other form, or store them as needed
        selectedID = id
        stockName.Text = name
        stockAmount.Text = stocks
    End Sub

    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        If stockName.Text = "" Or stockAmount.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else
            If ContainsInvalidChars(stockName.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            ' Validate smallPricePI: Check if it's a valid numeric value
            If Not IsNumeric(stockAmount.Text) Then
                MsgBox("Price should be a valid numeric value.")
                Return
            End If

            updates("UPDATE products SET  stocks='" & stockAmount.Text & "' WHERE productID='" & selectedID & "'")
            InventoryManagement.ReloadInventory()
            stockName.Text = ""
            stockAmount.Text = ""
            Me.Hide()
            MainForm.BringToFront()
        End If
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        stockName.Text = ""
        stockAmount.Text = ""
        Me.Hide()
        MainForm.BringToFront()
    End Sub

    Private Sub ProductStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class