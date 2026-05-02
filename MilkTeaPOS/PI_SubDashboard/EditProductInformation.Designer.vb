<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProductInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProductInformation))
        Me.largePricePI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.smallPricePI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.formTwoCancelBtn = New System.Windows.Forms.Button()
        Me.formTwoOkayBtn = New System.Windows.Forms.Button()
        Me.productNamePI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'largePricePI
        '
        Me.largePricePI.ForeColor = System.Drawing.Color.Black
        Me.largePricePI.Location = New System.Drawing.Point(185, 164)
        Me.largePricePI.Margin = New System.Windows.Forms.Padding(4)
        Me.largePricePI.Name = "largePricePI"
        Me.largePricePI.Size = New System.Drawing.Size(133, 22)
        Me.largePricePI.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(99, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Large:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(99, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Small:"
        '
        'smallPricePI
        '
        Me.smallPricePI.ForeColor = System.Drawing.Color.Black
        Me.smallPricePI.Location = New System.Drawing.Point(185, 122)
        Me.smallPricePI.Margin = New System.Windows.Forms.Padding(4)
        Me.smallPricePI.Name = "smallPricePI"
        Me.smallPricePI.Size = New System.Drawing.Size(133, 22)
        Me.smallPricePI.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Price: "
        '
        'formTwoCancelBtn
        '
        Me.formTwoCancelBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.formTwoCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoCancelBtn.Location = New System.Drawing.Point(169, 242)
        Me.formTwoCancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoCancelBtn.Name = "formTwoCancelBtn"
        Me.formTwoCancelBtn.Size = New System.Drawing.Size(160, 46)
        Me.formTwoCancelBtn.TabIndex = 30
        Me.formTwoCancelBtn.Text = "CANCEL"
        Me.formTwoCancelBtn.UseVisualStyleBackColor = True
        '
        'formTwoOkayBtn
        '
        Me.formTwoOkayBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.formTwoOkayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoOkayBtn.Location = New System.Drawing.Point(13, 242)
        Me.formTwoOkayBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoOkayBtn.Name = "formTwoOkayBtn"
        Me.formTwoOkayBtn.Size = New System.Drawing.Size(149, 46)
        Me.formTwoOkayBtn.TabIndex = 29
        Me.formTwoOkayBtn.Text = "OKAY"
        Me.formTwoOkayBtn.UseVisualStyleBackColor = True
        '
        'productNamePI
        '
        Me.productNamePI.ForeColor = System.Drawing.Color.Black
        Me.productNamePI.Location = New System.Drawing.Point(103, 77)
        Me.productNamePI.Margin = New System.Windows.Forms.Padding(4)
        Me.productNamePI.Name = "productNamePI"
        Me.productNamePI.Size = New System.Drawing.Size(215, 22)
        Me.productNamePI.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Name: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 54)
        Me.Panel1.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Edit Product Info"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(281, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'EditProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 314)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.largePricePI)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.smallPricePI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.formTwoCancelBtn)
        Me.Controls.Add(Me.formTwoOkayBtn)
        Me.Controls.Add(Me.productNamePI)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditProductInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditProductInformation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents largePricePI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents smallPricePI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents formTwoCancelBtn As Button
    Friend WithEvents formTwoOkayBtn As Button
    Friend WithEvents productNamePI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
End Class
