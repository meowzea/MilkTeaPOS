<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateProduct))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.formTwoCancelBtn = New System.Windows.Forms.Button()
        Me.formTwoOkayBtn = New System.Windows.Forms.Button()
        Me.productName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.stockTxtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.smallPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.largePrice = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create Product"
        '
        'formTwoCancelBtn
        '
        Me.formTwoCancelBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.formTwoCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoCancelBtn.Location = New System.Drawing.Point(167, 303)
        Me.formTwoCancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoCancelBtn.Name = "formTwoCancelBtn"
        Me.formTwoCancelBtn.Size = New System.Drawing.Size(160, 46)
        Me.formTwoCancelBtn.TabIndex = 17
        Me.formTwoCancelBtn.Text = "CANCEL"
        Me.formTwoCancelBtn.UseVisualStyleBackColor = True
        '
        'formTwoOkayBtn
        '
        Me.formTwoOkayBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.formTwoOkayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoOkayBtn.Location = New System.Drawing.Point(11, 303)
        Me.formTwoOkayBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoOkayBtn.Name = "formTwoOkayBtn"
        Me.formTwoOkayBtn.Size = New System.Drawing.Size(149, 46)
        Me.formTwoOkayBtn.TabIndex = 16
        Me.formTwoOkayBtn.Text = "OKAY"
        Me.formTwoOkayBtn.UseVisualStyleBackColor = True
        '
        'productName
        '
        Me.productName.ForeColor = System.Drawing.Color.Black
        Me.productName.Location = New System.Drawing.Point(101, 76)
        Me.productName.Margin = New System.Windows.Forms.Padding(4)
        Me.productName.Name = "productName"
        Me.productName.Size = New System.Drawing.Size(215, 22)
        Me.productName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 54)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(288, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'stockTxtbox
        '
        Me.stockTxtbox.ForeColor = System.Drawing.Color.Black
        Me.stockTxtbox.Location = New System.Drawing.Point(101, 114)
        Me.stockTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.stockTxtbox.Name = "stockTxtbox"
        Me.stockTxtbox.Size = New System.Drawing.Size(215, 22)
        Me.stockTxtbox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Stocks: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Price: "
        '
        'smallPrice
        '
        Me.smallPrice.ForeColor = System.Drawing.Color.Black
        Me.smallPrice.Location = New System.Drawing.Point(183, 154)
        Me.smallPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.smallPrice.Name = "smallPrice"
        Me.smallPrice.Size = New System.Drawing.Size(133, 22)
        Me.smallPrice.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(97, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Small:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(97, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Large:"
        '
        'largePrice
        '
        Me.largePrice.ForeColor = System.Drawing.Color.Black
        Me.largePrice.Location = New System.Drawing.Point(183, 196)
        Me.largePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.largePrice.Name = "largePrice"
        Me.largePrice.Size = New System.Drawing.Size(133, 22)
        Me.largePrice.TabIndex = 24
        '
        'CreateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.largePrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.smallPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.stockTxtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.formTwoCancelBtn)
        Me.Controls.Add(Me.formTwoOkayBtn)
        Me.Controls.Add(Me.productName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CreateProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateProduct"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents formTwoCancelBtn As Button
    Friend WithEvents formTwoOkayBtn As Button
    Friend WithEvents productName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents stockTxtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents smallPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents largePrice As TextBox
End Class
