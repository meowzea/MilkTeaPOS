<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordTbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.usernameTbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passRetype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 44)
        Me.Panel1.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(131, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(129, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 38)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "SIGN UP"
        '
        'passwordTbox
        '
        Me.passwordTbox.ForeColor = System.Drawing.Color.Black
        Me.passwordTbox.Location = New System.Drawing.Point(84, 126)
        Me.passwordTbox.Name = "passwordTbox"
        Me.passwordTbox.Size = New System.Drawing.Size(193, 20)
        Me.passwordTbox.TabIndex = 55
        Me.passwordTbox.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Password: "
        '
        'cancelBtn
        '
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(157, 231)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(120, 37)
        Me.cancelBtn.TabIndex = 52
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'confirmBtn
        '
        Me.confirmBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.confirmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.Location = New System.Drawing.Point(17, 231)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(112, 37)
        Me.confirmBtn.TabIndex = 51
        Me.confirmBtn.Text = "CONFIRM"
        Me.confirmBtn.UseVisualStyleBackColor = True
        '
        'usernameTbox
        '
        Me.usernameTbox.ForeColor = System.Drawing.Color.Black
        Me.usernameTbox.Location = New System.Drawing.Point(84, 90)
        Me.usernameTbox.Name = "usernameTbox"
        Me.usernameTbox.Size = New System.Drawing.Size(193, 20)
        Me.usernameTbox.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Username:"
        '
        'nameTbox
        '
        Me.nameTbox.ForeColor = System.Drawing.Color.Black
        Me.nameTbox.Location = New System.Drawing.Point(84, 55)
        Me.nameTbox.Name = "nameTbox"
        Me.nameTbox.Size = New System.Drawing.Size(193, 20)
        Me.nameTbox.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Name:"
        '
        'passRetype
        '
        Me.passRetype.ForeColor = System.Drawing.Color.Black
        Me.passRetype.Location = New System.Drawing.Point(84, 164)
        Me.passRetype.Name = "passRetype"
        Me.passRetype.Size = New System.Drawing.Size(193, 20)
        Me.passRetype.TabIndex = 59
        Me.passRetype.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 26)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Retype" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 199)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 60
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 280)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.passRetype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nameTbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.passwordTbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.usernameTbox)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGN UP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordTbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cancelBtn As Button
    Friend WithEvents confirmBtn As Button
    Friend WithEvents usernameTbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nameTbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents passRetype As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
End Class
