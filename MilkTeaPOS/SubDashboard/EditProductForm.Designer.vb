<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProductForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.formTwoCancelBtn = New System.Windows.Forms.Button()
        Me.formTwoOkayBtn = New System.Windows.Forms.Button()
        Me.comboBoxAddon = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboBoxSize = New System.Windows.Forms.ComboBox()
        Me.formTwoQuantity = New System.Windows.Forms.TextBox()
        Me.editProduct = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sugarComboBox = New System.Windows.Forms.ComboBox()
        Me.comboBoxAddon2 = New System.Windows.Forms.ComboBox()
        Me.comboBoxAddon1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 44)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(216, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Edit Product"
        '
        'formTwoCancelBtn
        '
        Me.formTwoCancelBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.formTwoCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoCancelBtn.Location = New System.Drawing.Point(126, 366)
        Me.formTwoCancelBtn.Name = "formTwoCancelBtn"
        Me.formTwoCancelBtn.Size = New System.Drawing.Size(120, 37)
        Me.formTwoCancelBtn.TabIndex = 23
        Me.formTwoCancelBtn.Text = "CANCEL"
        Me.formTwoCancelBtn.UseVisualStyleBackColor = True
        '
        'formTwoOkayBtn
        '
        Me.formTwoOkayBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.formTwoOkayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoOkayBtn.Location = New System.Drawing.Point(8, 366)
        Me.formTwoOkayBtn.Name = "formTwoOkayBtn"
        Me.formTwoOkayBtn.Size = New System.Drawing.Size(112, 37)
        Me.formTwoOkayBtn.TabIndex = 22
        Me.formTwoOkayBtn.Text = "OKAY"
        Me.formTwoOkayBtn.UseVisualStyleBackColor = True
        '
        'comboBoxAddon
        '
        Me.comboBoxAddon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxAddon.FormattingEnabled = True
        Me.comboBoxAddon.Location = New System.Drawing.Point(48, 246)
        Me.comboBoxAddon.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxAddon.Name = "comboBoxAddon"
        Me.comboBoxAddon.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxAddon.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(97, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Add Ons"
        '
        'comboBoxSize
        '
        Me.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSize.FormattingEnabled = True
        Me.comboBoxSize.Location = New System.Drawing.Point(83, 135)
        Me.comboBoxSize.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxSize.Name = "comboBoxSize"
        Me.comboBoxSize.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxSize.TabIndex = 19
        '
        'formTwoQuantity
        '
        Me.formTwoQuantity.Location = New System.Drawing.Point(84, 94)
        Me.formTwoQuantity.Name = "formTwoQuantity"
        Me.formTwoQuantity.Size = New System.Drawing.Size(162, 20)
        Me.formTwoQuantity.TabIndex = 18
        '
        'editProduct
        '
        Me.editProduct.ForeColor = System.Drawing.Color.Black
        Me.editProduct.Location = New System.Drawing.Point(84, 56)
        Me.editProduct.Name = "editProduct"
        Me.editProduct.Size = New System.Drawing.Size(162, 20)
        Me.editProduct.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Size: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Quantity: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Product: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(2, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Sugar %: "
        '
        'sugarComboBox
        '
        Me.sugarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sugarComboBox.FormattingEnabled = True
        Me.sugarComboBox.Items.AddRange(New Object() {"25%", "50%", "75%", "100%"})
        Me.sugarComboBox.Location = New System.Drawing.Point(80, 178)
        Me.sugarComboBox.Name = "sugarComboBox"
        Me.sugarComboBox.Size = New System.Drawing.Size(163, 21)
        Me.sugarComboBox.TabIndex = 28
        '
        'comboBoxAddon2
        '
        Me.comboBoxAddon2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxAddon2.FormattingEnabled = True
        Me.comboBoxAddon2.Location = New System.Drawing.Point(48, 333)
        Me.comboBoxAddon2.Name = "comboBoxAddon2"
        Me.comboBoxAddon2.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxAddon2.TabIndex = 27
        '
        'comboBoxAddon1
        '
        Me.comboBoxAddon1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxAddon1.FormattingEnabled = True
        Me.comboBoxAddon1.Location = New System.Drawing.Point(48, 290)
        Me.comboBoxAddon1.Name = "comboBoxAddon1"
        Me.comboBoxAddon1.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxAddon1.TabIndex = 26
        '
        'EditProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 415)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.sugarComboBox)
        Me.Controls.Add(Me.comboBoxAddon2)
        Me.Controls.Add(Me.comboBoxAddon1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.formTwoCancelBtn)
        Me.Controls.Add(Me.formTwoOkayBtn)
        Me.Controls.Add(Me.comboBoxAddon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboBoxSize)
        Me.Controls.Add(Me.formTwoQuantity)
        Me.Controls.Add(Me.editProduct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents formTwoCancelBtn As Button
    Friend WithEvents formTwoOkayBtn As Button
    Friend WithEvents comboBoxAddon As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents comboBoxSize As ComboBox
    Friend WithEvents formTwoQuantity As TextBox
    Friend WithEvents editProduct As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents sugarComboBox As ComboBox
    Friend WithEvents comboBoxAddon2 As ComboBox
    Friend WithEvents comboBoxAddon1 As ComboBox
End Class
