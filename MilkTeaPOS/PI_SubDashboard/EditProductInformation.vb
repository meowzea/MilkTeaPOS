Imports System.Windows.Controls.Primitives

Public Class EditProductInformation
    Dim selectedID As Integer
    Public Sub New(id As Integer, name As String, smallPrice As Integer, largePrice As Integer)
        ' Constructor to accept the values as parameters and set them
        InitializeComponent()

        ' Set the values in the controls of the other form, or store them as needed
        selectedID = id
        productNamePI.Text = name
        smallPricePI.Text = smallPrice
        largePricePI.Text = largePrice
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        productNamePI.Text = ""
        smallPricePI.Text = ""
        largePricePI.Text = ""
        Me.Hide()
        MainForm.BringToFront()
    End Sub

    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        If productNamePI.Text = "" Or smallPricePI.Text = "" Or largePricePI.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else
            If ContainsInvalidChars(productNamePI.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            ' Validate smallPricePI: Check if it's a valid numeric value
            If Not IsNumeric(smallPricePI.Text) Then
                MsgBox("Small price should be a valid numeric value.")
                Return
            End If

            ' Validate largePricePI: Check if it's a valid numeric value
            If Not IsNumeric(largePricePI.Text) Then
                MsgBox("Large price should be a valid numeric value.")
                Return
            End If

            updates("UPDATE products SET Variant='" & productNamePI.Text & "', smallPrice='" & smallPricePI.Text & "', largePrice='" & largePricePI.Text & "' WHERE productID='" & selectedID & "'")
            ProductInventory.ReloadTables()
            productNamePI.Text = ""
            smallPricePI.Text = ""
            largePricePI.Text = ""
            Me.Hide()
            MainForm.BringToFront()
        End If
    End Sub

    Private Sub EditProductInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class