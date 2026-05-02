<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.signupBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.usernameTbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordTbox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 44)
        Me.Panel1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(44, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "MILKTEA POS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Password: "
        '
        'signupBtn
        '
        Me.signupBtn.DialogResult = System.Windows.Forms.DialogResult.No
        Me.signupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupBtn.Location = New System.Drawing.Point(127, 166)
        Me.signupBtn.Name = "signupBtn"
        Me.signupBtn.Size = New System.Drawing.Size(120, 37)
        Me.signupBtn.TabIndex = 40
        Me.signupBtn.Text = "SIGNUP"
        Me.signupBtn.UseVisualStyleBackColor = True
        '
        'loginBtn
        '
        Me.loginBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Location = New System.Drawing.Point(10, 166)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(112, 37)
        Me.loginBtn.TabIndex = 39
        Me.loginBtn.Text = "LOGIN"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'usernameTbox
        '
        Me.usernameTbox.ForeColor = System.Drawing.Color.Black
        Me.usernameTbox.Location = New System.Drawing.Point(83, 64)
        Me.usernameTbox.Name = "usernameTbox"
        Me.usernameTbox.Size = New System.Drawing.Size(162, 20)
        Me.usernameTbox.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Username:"
        '
        'passwordTbox
        '
        Me.passwordTbox.ForeColor = System.Drawing.Color.Black
        Me.passwordTbox.Location = New System.Drawing.Point(83, 99)
        Me.passwordTbox.Name = "passwordTbox"
        Me.passwordTbox.Size = New System.Drawing.Size(162, 20)
        Me.passwordTbox.TabIndex = 47
        Me.passwordTbox.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 135)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 48
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(257, 215)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.passwordTbox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.signupBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.usernameTbox)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents signupBtn As Button
    Friend WithEvents loginBtn As Button
    Friend WithEvents usernameTbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTbox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
