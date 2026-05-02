<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuyForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuyForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelForm3 = New System.Windows.Forms.Panel()
        Me.qtyLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.payBtn = New System.Windows.Forms.Button()
        Me.DataGridViewCart = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewProducts = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelForm3.SuspendLayout()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelForm3
        '
        Me.PanelForm3.BackColor = System.Drawing.Color.LightGray
        Me.PanelForm3.Controls.Add(Me.qtyLbl)
        Me.PanelForm3.Controls.Add(Me.Label5)
        Me.PanelForm3.Controls.Add(Me.totalLbl)
        Me.PanelForm3.Controls.Add(Me.Label4)
        Me.PanelForm3.Controls.Add(Me.timeLbl)
        Me.PanelForm3.Controls.Add(Me.cancelBtn)
        Me.PanelForm3.Controls.Add(Me.payBtn)
        Me.PanelForm3.Controls.Add(Me.DataGridViewCart)
        Me.PanelForm3.Controls.Add(Me.Label3)
        Me.PanelForm3.Controls.Add(Me.DataGridViewProducts)
        Me.PanelForm3.Controls.Add(Me.searchTxtBox)
        Me.PanelForm3.Controls.Add(Me.Label2)
        Me.PanelForm3.Controls.Add(Me.Label1)
        Me.PanelForm3.Controls.Add(Me.PictureBox2)
        Me.PanelForm3.Controls.Add(Me.Label6)
        Me.PanelForm3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm3.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm3.Name = "PanelForm3"
        Me.PanelForm3.Size = New System.Drawing.Size(1843, 1041)
        Me.PanelForm3.TabIndex = 2
        '
        'qtyLbl
        '
        Me.qtyLbl.AutoSize = True
        Me.qtyLbl.BackColor = System.Drawing.Color.Transparent
        Me.qtyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyLbl.ForeColor = System.Drawing.Color.Gray
        Me.qtyLbl.Location = New System.Drawing.Point(1199, 810)
        Me.qtyLbl.Name = "qtyLbl"
        Me.qtyLbl.Size = New System.Drawing.Size(52, 55)
        Me.qtyLbl.TabIndex = 15
        Me.qtyLbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(916, 810)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 55)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "QUANTITY: "
        '
        'totalLbl
        '
        Me.totalLbl.AutoSize = True
        Me.totalLbl.BackColor = System.Drawing.Color.Transparent
        Me.totalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLbl.ForeColor = System.Drawing.Color.Gray
        Me.totalLbl.Location = New System.Drawing.Point(1239, 700)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(52, 55)
        Me.totalLbl.TabIndex = 13
        Me.totalLbl.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(916, 700)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 55)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TOTAL:"
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.BackColor = System.Drawing.Color.Transparent
        Me.timeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLbl.ForeColor = System.Drawing.Color.Gray
        Me.timeLbl.Location = New System.Drawing.Point(12, 47)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(75, 20)
        Me.timeLbl.TabIndex = 11
        Me.timeLbl.Text = "Milk Tea"
        '
        'cancelBtn
        '
        Me.cancelBtn.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Group_11green
        Me.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelBtn.Location = New System.Drawing.Point(1522, 924)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(298, 81)
        Me.cancelBtn.TabIndex = 10
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'payBtn
        '
        Me.payBtn.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Group_11green
        Me.payBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.payBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.payBtn.FlatAppearance.BorderSize = 0
        Me.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.payBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.payBtn.Location = New System.Drawing.Point(926, 925)
        Me.payBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(298, 80)
        Me.payBtn.TabIndex = 9
        Me.payBtn.Text = "PAY"
        Me.payBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.payBtn.UseVisualStyleBackColor = True
        '
        'DataGridViewCart
        '
        Me.DataGridViewCart.AllowUserToAddRows = False
        Me.DataGridViewCart.AllowUserToDeleteRows = False
        Me.DataGridViewCart.AllowUserToResizeColumns = False
        Me.DataGridViewCart.AllowUserToResizeRows = False
        Me.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridViewCart.Location = New System.Drawing.Point(909, 82)
        Me.DataGridViewCart.Name = "DataGridViewCart"
        Me.DataGridViewCart.ReadOnly = True
        Me.DataGridViewCart.RowHeadersWidth = 51
        Me.DataGridViewCart.Size = New System.Drawing.Size(922, 540)
        Me.DataGridViewCart.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(916, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cart"
        '
        'DataGridViewProducts
        '
        Me.DataGridViewProducts.AllowUserToAddRows = False
        Me.DataGridViewProducts.AllowUserToDeleteRows = False
        Me.DataGridViewProducts.AllowUserToResizeColumns = False
        Me.DataGridViewProducts.AllowUserToResizeRows = False
        Me.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3})
        Me.DataGridViewProducts.Location = New System.Drawing.Point(16, 82)
        Me.DataGridViewProducts.Name = "DataGridViewProducts"
        Me.DataGridViewProducts.ReadOnly = True
        Me.DataGridViewProducts.RowHeadersWidth = 51
        Me.DataGridViewProducts.Size = New System.Drawing.Size(878, 947)
        Me.DataGridViewProducts.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = "SELECT"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column3.HeaderText = ""
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Text = "SELECT"
        '
        'searchTxtBox
        '
        Me.searchTxtBox.Location = New System.Drawing.Point(678, 56)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(216, 20)
        Me.searchTxtBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(130, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "POS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Milk Tea"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(637, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(1107, 700)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 55)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "PHP"
        '
        'Timer1
        '
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "EDIT"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column1.HeaderText = ""
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Text = "EDIT"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.NullValue = "DELETE"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column2.HeaderText = ""
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "DELETE"
        '
        'BuyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1843, 1041)
        Me.Controls.Add(Me.PanelForm3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuyForm"
        Me.Text = "Form3"
        Me.PanelForm3.ResumeLayout(False)
        Me.PanelForm3.PerformLayout()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm3 As Panel
    Friend WithEvents DataGridViewCart As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewProducts As DataGridView
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents payBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalLbl As Label
    Friend WithEvents qtyLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
End Class
