<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOnsStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddOnsStock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addOnsStockAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.formTwoCancelBtn = New System.Windows.Forms.Button()
        Me.formTwoOkayBtn = New System.Windows.Forms.Button()
        Me.addOnsStockName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(325, 54)
        Me.Panel1.TabIndex = 50
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(275, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 29)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Edit Purchase Order"
        '
        'addOnsStockAmount
        '
        Me.addOnsStockAmount.ForeColor = System.Drawing.Color.Black
        Me.addOnsStockAmount.Location = New System.Drawing.Point(183, 123)
        Me.addOnsStockAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.addOnsStockAmount.Name = "addOnsStockAmount"
        Me.addOnsStockAmount.Size = New System.Drawing.Size(129, 22)
        Me.addOnsStockAmount.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Purchase Orders:"
        '
        'formTwoCancelBtn
        '
        Me.formTwoCancelBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.formTwoCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoCancelBtn.Location = New System.Drawing.Point(161, 177)
        Me.formTwoCancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoCancelBtn.Name = "formTwoCancelBtn"
        Me.formTwoCancelBtn.Size = New System.Drawing.Size(160, 46)
        Me.formTwoCancelBtn.TabIndex = 47
        Me.formTwoCancelBtn.Text = "CANCEL"
        Me.formTwoCancelBtn.UseVisualStyleBackColor = True
        '
        'formTwoOkayBtn
        '
        Me.formTwoOkayBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.formTwoOkayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formTwoOkayBtn.Location = New System.Drawing.Point(8, 177)
        Me.formTwoOkayBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.formTwoOkayBtn.Name = "formTwoOkayBtn"
        Me.formTwoOkayBtn.Size = New System.Drawing.Size(149, 46)
        Me.formTwoOkayBtn.TabIndex = 46
        Me.formTwoOkayBtn.Text = "OKAY"
        Me.formTwoOkayBtn.UseVisualStyleBackColor = True
        '
        'addOnsStockName
        '
        Me.addOnsStockName.ForeColor = System.Drawing.Color.Black
        Me.addOnsStockName.Location = New System.Drawing.Point(101, 78)
        Me.addOnsStockName.Margin = New System.Windows.Forms.Padding(4)
        Me.addOnsStockName.Name = "addOnsStockName"
        Me.addOnsStockName.ReadOnly = True
        Me.addOnsStockName.Size = New System.Drawing.Size(215, 22)
        Me.addOnsStockName.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Name: "
        '
        'AddOnsStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 229)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.addOnsStockAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.formTwoCancelBtn)
        Me.Controls.Add(Me.formTwoOkayBtn)
        Me.Controls.Add(Me.addOnsStockName)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddOnsStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddOnsStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents addOnsStockAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents formTwoCancelBtn As Button
    Friend WithEvents formTwoOkayBtn As Button
    Friend WithEvents addOnsStockName As TextBox
    Friend WithEvents Label2 As Label
End Class
