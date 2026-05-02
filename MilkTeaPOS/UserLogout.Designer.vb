<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogout
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.currentUserLbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.MilkTeaPOS.My.Resources.Resources.Male_User_big
        Me.PictureBox1.Location = New System.Drawing.Point(46, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Rectangle_7
        Me.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.FlatAppearance.BorderSize = 0
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.Transparent
        Me.logoutBtn.Location = New System.Drawing.Point(74, 307)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(170, 45)
        Me.logoutBtn.TabIndex = 11
        Me.logoutBtn.Text = "LOG OUT"
        Me.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.logoutBtn.UseVisualStyleBackColor = True
        '
        'currentUserLbl
        '
        Me.currentUserLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.currentUserLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentUserLbl.ForeColor = System.Drawing.Color.Transparent
        Me.currentUserLbl.Location = New System.Drawing.Point(12, 260)
        Me.currentUserLbl.Name = "currentUserLbl"
        Me.currentUserLbl.Size = New System.Drawing.Size(290, 23)
        Me.currentUserLbl.TabIndex = 12
        Me.currentUserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.currentUserLbl)
        Me.Panel2.Controls.Add(Me.logoutBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 363)
        Me.Panel2.TabIndex = 13
        '
        'UserLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 363)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserLogout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoutBtn As Button
    Friend WithEvents currentUserLbl As Label
    Friend WithEvents Panel2 As Panel
End Class
