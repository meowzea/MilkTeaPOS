<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManagement))
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.DataGridViewAddOnsInventory = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewProductInventory = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewAddOnsInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewProductInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.BackColor = System.Drawing.Color.Transparent
        Me.timeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLbl.ForeColor = System.Drawing.Color.Gray
        Me.timeLbl.Location = New System.Drawing.Point(16, 54)
        Me.timeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(95, 25)
        Me.timeLbl.TabIndex = 16
        Me.timeLbl.Text = "Milk Tea"
        '
        'DataGridViewAddOnsInventory
        '
        Me.DataGridViewAddOnsInventory.AllowUserToAddRows = False
        Me.DataGridViewAddOnsInventory.AllowUserToDeleteRows = False
        Me.DataGridViewAddOnsInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAddOnsInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewAddOnsInventory.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridViewAddOnsInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAddOnsInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column9, Me.Column7})
        Me.DataGridViewAddOnsInventory.Location = New System.Drawing.Point(597, 89)
        Me.DataGridViewAddOnsInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewAddOnsInventory.Name = "DataGridViewAddOnsInventory"
        Me.DataGridViewAddOnsInventory.ReadOnly = True
        Me.DataGridViewAddOnsInventory.RowHeadersWidth = 51
        Me.DataGridViewAddOnsInventory.RowTemplate.Height = 24
        Me.DataGridViewAddOnsInventory.Size = New System.Drawing.Size(507, 464)
        Me.DataGridViewAddOnsInventory.TabIndex = 15
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
        Me.Column9.DataPropertyName = "stock"
        Me.Column9.HeaderText = "Stocks"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column7.HeaderText = ""
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Text = "EDIT"
        Me.Column7.UseColumnTextForButtonValue = True
        '
        'DataGridViewProductInventory
        '
        Me.DataGridViewProductInventory.AllowUserToAddRows = False
        Me.DataGridViewProductInventory.AllowUserToDeleteRows = False
        Me.DataGridViewProductInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductInventory.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridViewProductInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column2, Me.Column11, Me.Column3})
        Me.DataGridViewProductInventory.Location = New System.Drawing.Point(20, 89)
        Me.DataGridViewProductInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewProductInventory.Name = "DataGridViewProductInventory"
        Me.DataGridViewProductInventory.ReadOnly = True
        Me.DataGridViewProductInventory.RowHeadersWidth = 51
        Me.DataGridViewProductInventory.RowTemplate.Height = 24
        Me.DataGridViewProductInventory.Size = New System.Drawing.Size(557, 464)
        Me.DataGridViewProductInventory.TabIndex = 14
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
        'Column11
        '
        Me.Column11.DataPropertyName = "stocks"
        Me.Column11.HeaderText = "Stocks"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Column3"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.FillWeight = 121.9251!
        Me.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column3.HeaderText = ""
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "EDIT"
        Me.Column3.UseColumnTextForButtonValue = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 42)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Inventory Management"
        '
        'Timer1
        '
        '
        'searchTxtBox
        '
        Me.searchTxtBox.Location = New System.Drawing.Point(937, 30)
        Me.searchTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(167, 22)
        Me.searchTxtBox.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(889, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'InventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 575)
        Me.Controls.Add(Me.searchTxtBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.DataGridViewAddOnsInventory)
        Me.Controls.Add(Me.DataGridViewProductInventory)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InventoryManagement"
        Me.Text = "b"
        CType(Me.DataGridViewAddOnsInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewProductInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeLbl As Label
    Friend WithEvents DataGridViewAddOnsInventory As DataGridView
    Friend WithEvents DataGridViewProductInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
