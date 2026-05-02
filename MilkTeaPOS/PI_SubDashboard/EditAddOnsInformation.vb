Public Class EditAddOnsInformation
    Dim selectedID As Integer
    Public Sub New(id As Integer, name As String, price As Integer)
        ' Constructor to accept the values as parameters and set them
        InitializeComponent()

        ' Set the values in the controls of the other form, or store them as needed
        selectedID = id
        addOnsName.Text = name
        addOnsPrice.Text = price
    End Sub

    Private Sub EditAddOnsInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub formTwoOkayBtn_Click(sender As Object, e As EventArgs) Handles formTwoOkayBtn.Click
        If addOnsName.Text = "" Or addOnsPrice.Text = "" Then
            MessageBox.Show("Please fill the required fields.")
        Else
            If ContainsInvalidChars(addOnsName.Text) Then
                MsgBox("Add-ons name should only contain letters.")
                Return
            End If

            If Not IsNumeric(addOnsPrice.Text) Then
                MsgBox("Price should be a valid numeric value.")
                Return
            End If

            updates("UPDATE addons SET addOnsName='" & addOnsName.Text & "', price='" & addOnsPrice.Text & "' WHERE addOnsID='" & selectedID & "'")
            ProductInventory.ReloadTables()
            addOnsName.Text = ""
            addOnsPrice.Text = ""
            Me.Hide()
            MainForm.BringToFront()
        End If
    End Sub

    Private Sub formTwoCancelBtn_Click(sender As Object, e As EventArgs) Handles formTwoCancelBtn.Click
        addOnsName.Text = ""
        addOnsPrice.Text = ""
        Me.Hide()
        MainForm.BringToFront()
    End Sub
End Class