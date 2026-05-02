
Imports System.Text.RegularExpressions

Public Class CreateProduct

    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        If productName.Text = "" Or smallPrice.Text = "" Or largePrice.Text = "" Or stockTxtbox.Text = "" Then
            MsgBox("Please fill the required fields.")
        Else
            If ContainsInvalidChars(productName.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            If Not IsNumeric(smallPrice.Text) Then
                MsgBox("Small price should be a valid numeric value.")
                Return
            End If

            If Not IsNumeric(largePrice.Text) Then
                MsgBox("Large price should be a valid numeric value.")
                Return
            End If

            If Not IsNumeric(stockTxtbox.Text) Then
                MsgBox("Stocks should be a valid numeric value.")
                Return
            End If


            createVariant("INSERT INTO products (Variant, smallPrice, largePrice, stocks) VALUES('" & productName.Text & "','" & smallPrice.Text & "', '" & largePrice.Text & "','" & stockTxtbox.Text & "')")
            productName.Text = ""
            smallPrice.Text = ""
            largePrice.Text = ""
            stockTxtbox.Text = ""
            ProductInventory.reloadInventory()
            Me.Hide()
            MainForm.BringToFront()

            BuyForm.ProductLoad()

            AddProductForm.ReloadAddonComBox()
            EditProductForm.ReloadAddonComBox()
        End If
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        productName.Text = ""
        smallPrice.Text = ""
        largePrice.Text = ""
        stockTxtbox.Text = ""
        Me.Hide()
        MainForm.BringToFront()
    End Sub

    Private Sub productName_TextChanged(sender As Object, e As EventArgs) Handles productName.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub largePrice_TextChanged(sender As Object, e As EventArgs) Handles largePrice.TextChanged

    End Sub

    Private Sub smallPrice_TextChanged(sender As Object, e As EventArgs) Handles smallPrice.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class