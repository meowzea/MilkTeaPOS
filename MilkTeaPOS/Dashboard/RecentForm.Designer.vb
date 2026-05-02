<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecentForm
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
        Me.dgvRecentOrders = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.resetSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvRecentOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecentOrders
        '
        Me.dgvRecentOrders.AllowUserToAddRows = False
        Me.dgvRecentOrders.AllowUserToDeleteRows = False
        Me.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentOrders.Location = New System.Drawing.Point(12, 73)
        Me.dgvRecentOrders.Name = "dgvRecentOrders"
        Me.dgvRecentOrders.ReadOnly = True
        Me.dgvRecentOrders.Size = New System.Drawing.Size(1819, 855)
        Me.dgvRecentOrders.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(1491, 25)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(178, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1279, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Inter", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1463, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "-"
        '
        'deleteBtn
        '
        Me.deleteBtn.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Rectangle_7
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deleteBtn.Location = New System.Drawing.Point(11, 933)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(298, 97)
        Me.deleteBtn.TabIndex = 10
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'resetSearch
        '
        Me.resetSearch.BackgroundImage = Global.MilkTeaPOS.My.Resources.Resources.Rectangle_71
        Me.resetSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.resetSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetSearch.FlatAppearance.BorderSize = 0
        Me.resetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.resetSearch.Location = New System.Drawing.Point(1674, 5)
        Me.resetSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.resetSearch.Name = "resetSearch"
        Me.resetSearch.Size = New System.Drawing.Size(158, 63)
        Me.resetSearch.TabIndex = 16
        Me.resetSearch.Text = "Reset"
        Me.resetSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.resetSearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 55)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Orders"
        '
        'RecentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1843, 1041)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvRecentOrders)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.resetSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecentForm"
        Me.Text = "Recent"
        CType(Me.dgvRecentOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRecentOrders As DataGridView
    Friend WithEvents deleteBtn As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents resetSearch As Button
    Friend WithEvents Label3 As Label
End Class
