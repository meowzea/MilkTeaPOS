Public Class CreateAddons


    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        If addOnName.Text = "" Or addOnStock.Text = "" Or addOnPrice.Text = "" Then
            MsgBox("Please fill the required fiels.")
        Else
            If ContainsInvalidChars(addOnName.Text) Then
                MsgBox("Product name should only contain letters.")
                Return
            End If

            If Not IsNumeric(addOnPrice.Text) Then
                MsgBox("Price should be a valid numeric value.")
                Return
            End If

            If Not IsNumeric(addOnStock.Text) Then
                MsgBox("Stocks should be a valid numeric value.")
                Return
            End If

            createVariant("INSERT INTO addons (`addOnsName`, `stock`, `price`) VALUES ('" & addOnName.Text & "', '" & addOnStock.Text & "', '" & addOnPrice.Text & "')")
            addOnName.Text = ""
            addOnStock.Text = ""
            addOnPrice.Text = ""
            ProductInventory.reloadInventory()
            Me.Hide()
            MainForm.BringToFront()

            AddProductForm.ReloadAddonComBox()
            EditProductForm.ReloadAddonComBox()
        End If
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        addOnName.Text = ""
        addOnStock.Text = ""
        addOnPrice.Text = ""
        Me.Hide()
        MainForm.BringToFront()
    End Sub
End Class