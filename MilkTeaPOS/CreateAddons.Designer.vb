<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAddons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAddons))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addOnStock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.formTwoCancelBtn = New System.Windows.Forms.Button()
        Me.formTwoOkayBtn = New System.Windows.Forms.Button()
        Me.addOnName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addOnPrice = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Price: "
        '
        'addOnStock
        '
        Me.addOnStock.ForeColor = System.Drawing.Color.Black
        Me.addOnStock.Location = New System.Drawing.Point(103, 121)
        Me.addOnStock.Margin = New System.Windows.Forms.Padding(4)
        Me.addOnStock.Name = "addOnStock"
        Me.addOnStock.Size = New System.Drawing.Size(215, 22)
        Me.addOnStock.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Stock: "
        '
        'formTwoCancelBtn
        '
        Me.formTwoCancelBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.formTwoCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoCancelBtn.Location = New System.Drawing.Point(170, 217)
        Me.formTwoCancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoCancelBtn.Name = "formTwoCancelBtn"
        Me.formTwoCancelBtn.Size = New System.Drawing.Size(160, 46)
        Me.formTwoCancelBtn.TabIndex = 26
        Me.formTwoCancelBtn.Text = "CANCEL"
        Me.formTwoCancelBtn.UseVisualStyleBackColor = True
        '
        'formTwoOkayBtn
        '
        Me.formTwoOkayBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.formTwoOkayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoOkayBtn.Location = New System.Drawing.Point(13, 217)
        Me.formTwoOkayBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoOkayBtn.Name = "formTwoOkayBtn"
        Me.formTwoOkayBtn.Size = New System.Drawing.Size(149, 46)
        Me.formTwoOkayBtn.TabIndex = 25
        Me.formTwoOkayBtn.Text = "OKAY"
        Me.formTwoOkayBtn.UseVisualStyleBackColor = True
        '
        'addOnName
        '
        Me.addOnName.ForeColor = System.Drawing.Color.Black
        Me.addOnName.Location = New System.Drawing.Point(103, 82)
        Me.addOnName.Margin = New System.Windows.Forms.Padding(4)
        Me.addOnName.Name = "addOnName"
        Me.addOnName.Size = New System.Drawing.Size(215, 22)
        Me.addOnName.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name: "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(291, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 42)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Create Add-ons"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 54)
        Me.Panel1.TabIndex = 30
        '
        'addOnPrice
        '
        Me.addOnPrice.ForeColor = System.Drawing.Color.Black
        Me.addOnPrice.Location = New System.Drawing.Point(103, 162)
        Me.addOnPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.addOnPrice.Name = "addOnPrice"
        Me.addOnPrice.Size = New System.Drawing.Size(215, 22)
        Me.addOnPrice.TabIndex = 31
        '
        'CreateAddons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.addOnPrice)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addOnStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.formTwoCancelBtn)
        Me.Controls.Add(Me.formTwoOkayBtn)
        Me.Controls.Add(Me.addOnName)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAddons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAddons"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents addOnStock As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents formTwoCancelBtn As Button
    Friend WithEvents formTwoOkayBtn As Button
    Friend WithEvents addOnName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents addOnPrice As TextBox
End Class
