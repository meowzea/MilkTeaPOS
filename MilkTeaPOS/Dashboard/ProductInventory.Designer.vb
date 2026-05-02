<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductInventory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewProductManagement = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewAddOns = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.addOnsBtn = New System.Windows.Forms.Button()
        Me.addProductBtn = New System.Windows.Forms.Button()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewProductManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAddOns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 171)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Management"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 266)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 4
        '
        'DataGridViewProductManagement
        '
        Me.DataGridViewProductManagement.AllowUserToAddRows = False
        Me.DataGridViewProductManagement.AllowUserToDeleteRows = False
        Me.DataGridViewProductManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductManagement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductManagement.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridViewProductManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductManagement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column2, Me.Column1, Me.Column11, Me.Column3, Me.Column4})
        Me.DataGridViewProductManagement.Location = New System.Drawing.Point(15, 71)
        Me.DataGridViewProductManagement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewProductManagement.Name = "DataGridViewProductManagement"
        Me.DataGridViewProductManagement.ReadOnly = True
        Me.DataGridViewProductManagement.RowHeadersWidth = 51
        Me.DataGridViewProductManagement.RowTemplate.Height = 24
        Me.DataGridViewProductManagement.Size = New System.Drawing.Size(958, 850)
        Me.DataGridViewProductManagement.TabIndex = 5
        '
        'ID
        '
        Me.ID.DataPropertyName = "productID"
        Me.ID.FillWeight = 92.69162!
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Variant"
        Me.Column2.FillWeight = 92.69162!
        Me.Column2.HeaderText = "Variant"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "smallPrice"
        Me.Column1.HeaderText = "Small Price"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "largePrice"
        Me.Column11.HeaderText = "Large Price"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Column3"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.FillWeight = 121.9251!
        Me.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column3.HeaderText = ""
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "EDIT"
        Me.Column3.UseColumnTextForButtonValue = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.FillWeight = 92.69162!
        Me.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column4.HeaderText = ""
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Text = "DELETE"
        Me.Column4.UseColumnTextForButtonValue = True
        '
        'DataGridViewAddOns
        '
        Me.DataGridViewAddOns.AllowUserToAddRows = False
        Me.DataGridViewAddOns.AllowUserToDeleteRows = False
        Me.DataGridViewAddOns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAddOns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewAddOns.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridViewAddOns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAddOns.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column9, Me.Column7, Me.Column8})
        Me.DataGridViewAddOns.Location = New System.Drawing.Point(996, 71)
        Me.DataGridViewAddOns.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewAddOns.Name = "DataGridViewAddOns"
        Me.DataGridViewAddOns.ReadOnly = True
        Me.DataGridViewAddOns.RowHeadersWidth = 51
        Me.DataGridViewAddOns.RowTemplate.Height = 24
        Me.DataGridViewAddOns.Size = New System.Drawing.Size(829, 850)
        Me.DataGridViewAddOns.TabIndex = 6
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "addOnsID"
        Me.Column5.HeaderText = "ID"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "addOnsName"
        Me.Column6.HeaderText = "Add-on"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "price"
        Me.Column9.HeaderText = "Price"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column7.HeaderText = ""
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Text = "EDIT"
        Me.Column7.UseColumnTextForButtonValue = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column8.HeaderText = ""
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Text = "DELETE"
        Me.Column8.UseColumnTextForButtonValue = True
        '
        'addOnsBtn
        '
        Me.addOnsBtn.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Group_11green
        Me.addOnsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addOnsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addOnsBtn.FlatAppearance.BorderSize = 0
        Me.addOnsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addOnsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addOnsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.addOnsBtn.Location = New System.Drawing.Point(1459, 932)
        Me.addOnsBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addOnsBtn.Name = "addOnsBtn"
        Me.addOnsBtn.Size = New System.Drawing.Size(366, 100)
        Me.addOnsBtn.TabIndex = 8
        Me.addOnsBtn.Text = "Add Add-ons"
        Me.addOnsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.addOnsBtn.UseVisualStyleBackColor = True
        '
        'addProductBtn
        '
        Me.addProductBtn.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Group_11green
        Me.addProductBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addProductBtn.FlatAppearance.BorderSize = 0
        Me.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.addProductBtn.Location = New System.Drawing.Point(602, 932)
        Me.addProductBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addProductBtn.Name = "addProductBtn"
        Me.addProductBtn.Size = New System.Drawing.Size(369, 100)
        Me.addProductBtn.TabIndex = 7
        Me.addProductBtn.Text = "Add Product"
        Me.addProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.addProductBtn.UseVisualStyleBackColor = True
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.BackColor = System.Drawing.Color.Transparent
        Me.timeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLbl.ForeColor = System.Drawing.Color.Gray
        Me.timeLbl.Location = New System.Drawing.Point(12, 43)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(75, 20)
        Me.timeLbl.TabIndex = 12
        Me.timeLbl.Text = "Milk Tea"
        '
        'Timer1
        '
        '
        'searchTxtBox
        '
        Me.searchTxtBox.Location = New System.Drawing.Point(770, 46)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(203, 20)
        Me.searchTxtBox.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(729, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'ProductInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1843, 1041)
        Me.ControlBox = False
        Me.Controls.Add(Me.searchTxtBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.addOnsBtn)
        Me.Controls.Add(Me.addProductBtn)
        Me.Controls.Add(Me.DataGridViewAddOns)
        Me.Controls.Add(Me.DataGridViewProductManagement)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ProductInventory"
        Me.Text = "ProductInventory"
        CType(Me.DataGridViewProductManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAddOns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewProductManagement As DataGridView
    Friend WithEvents DataGridViewAddOns As DataGridView
    Friend WithEvents addProductBtn As Button
    Friend WithEvents addOnsBtn As Button
    Friend WithEvents timeLbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents Column8 As DataGridViewButtonColumn
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
