<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.accountBtn = New System.Windows.Forms.Button()
        Me.analyticsBtn = New System.Windows.Forms.Button()
        Me.recentBtn = New System.Windows.Forms.Button()
        Me.manageProductBtn = New System.Windows.Forms.Button()
        Me.editProductBtn = New System.Windows.Forms.Button()
        Me.buyBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.accountBtn)
        Me.Panel1.Controls.Add(Me.analyticsBtn)
        Me.Panel1.Controls.Add(Me.recentBtn)
        Me.Panel1.Controls.Add(Me.manageProductBtn)
        Me.Panel1.Controls.Add(Me.editProductBtn)
        Me.Panel1.Controls.Add(Me.buyBtn)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 467)
        Me.Panel1.TabIndex = 0
        '
        'accountBtn
        '
        Me.accountBtn.BackColor = System.Drawing.Color.Transparent
        Me.accountBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.accountBtn.FlatAppearance.BorderSize = 0
        Me.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountBtn.Image = Global.MilkTeaPOS.My.Resources.Resources.Male_User
        Me.accountBtn.Location = New System.Drawing.Point(0, 415)
        Me.accountBtn.Name = "accountBtn"
        Me.accountBtn.Size = New System.Drawing.Size(61, 52)
        Me.accountBtn.TabIndex = 9
        Me.accountBtn.UseVisualStyleBackColor = False
        '
        'analyticsBtn
        '
        Me.analyticsBtn.BackColor = System.Drawing.Color.Transparent
        Me.analyticsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.analyticsBtn.FlatAppearance.BorderSize = 0
        Me.analyticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.analyticsBtn.Image = CType(resources.GetObject("analyticsBtn.Image"), System.Drawing.Image)
        Me.analyticsBtn.Location = New System.Drawing.Point(0, 290)
        Me.analyticsBtn.Name = "analyticsBtn"
        Me.analyticsBtn.Size = New System.Drawing.Size(61, 52)
        Me.analyticsBtn.TabIndex = 8
        Me.analyticsBtn.UseVisualStyleBackColor = False
        '
        'recentBtn
        '
        Me.recentBtn.BackColor = System.Drawing.Color.Transparent
        Me.recentBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.recentBtn.FlatAppearance.BorderSize = 0
        Me.recentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recentBtn.Image = CType(resources.GetObject("recentBtn.Image"), System.Drawing.Image)
        Me.recentBtn.Location = New System.Drawing.Point(0, 238)
        Me.recentBtn.Name = "recentBtn"
        Me.recentBtn.Size = New System.Drawing.Size(61, 52)
        Me.recentBtn.TabIndex = 7
        Me.recentBtn.UseVisualStyleBackColor = False
        '
        'manageProductBtn
        '
        Me.manageProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.manageProductBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.manageProductBtn.FlatAppearance.BorderSize = 0
        Me.manageProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageProductBtn.Image = CType(resources.GetObject("manageProductBtn.Image"), System.Drawing.Image)
        Me.manageProductBtn.Location = New System.Drawing.Point(0, 186)
        Me.manageProductBtn.Name = "manageProductBtn"
        Me.manageProductBtn.Size = New System.Drawing.Size(61, 52)
        Me.manageProductBtn.TabIndex = 3
        Me.manageProductBtn.UseVisualStyleBackColor = False
        '
        'editProductBtn
        '
        Me.editProductBtn.BackColor = System.Drawing.Color.Transparent
        Me.editProductBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.editProductBtn.FlatAppearance.BorderSize = 0
        Me.editProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editProductBtn.Image = CType(resources.GetObject("editProductBtn.Image"), System.Drawing.Image)
        Me.editProductBtn.Location = New System.Drawing.Point(0, 134)
        Me.editProductBtn.Name = "editProductBtn"
        Me.editProductBtn.Size = New System.Drawing.Size(61, 52)
        Me.editProductBtn.TabIndex = 2
        Me.editProductBtn.UseVisualStyleBackColor = False
        '
        'buyBtn
        '
        Me.buyBtn.BackColor = System.Drawing.Color.Transparent
        Me.buyBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.buyBtn.FlatAppearance.BorderSize = 0
        Me.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buyBtn.Image = CType(resources.GetObject("buyBtn.Image"), System.Drawing.Image)
        Me.buyBtn.Location = New System.Drawing.Point(0, 82)
        Me.buyBtn.Name = "buyBtn"
        Me.buyBtn.Size = New System.Drawing.Size(61, 52)
        Me.buyBtn.TabIndex = 1
        Me.buyBtn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(61, 82)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(61, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(845, 467)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(495, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 73)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "POS"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(228, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 73)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Milk Tea"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(158, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(906, 467)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MILKTEA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents buyBtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents manageProductBtn As Button
    Friend WithEvents editProductBtn As Button
    Friend WithEvents analyticsBtn As Button
    Friend WithEvents recentBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents accountBtn As Button
End Class
