<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionLogs))
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgTransactionLogs = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtgReceipt = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.quantitySold = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgTransactionLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.timeLbl.TabIndex = 14
        Me.timeLbl.Text = "Milk Tea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 36)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Transaction Logs"
        '
        'dtgTransactionLogs
        '
        Me.dtgTransactionLogs.AllowUserToAddRows = False
        Me.dtgTransactionLogs.AllowUserToDeleteRows = False
        Me.dtgTransactionLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgTransactionLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgTransactionLogs.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dtgTransactionLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTransactionLogs.Location = New System.Drawing.Point(903, 70)
        Me.dtgTransactionLogs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtgTransactionLogs.Name = "dtgTransactionLogs"
        Me.dtgTransactionLogs.ReadOnly = True
        Me.dtgTransactionLogs.RowHeadersWidth = 51
        Me.dtgTransactionLogs.RowTemplate.Height = 24
        Me.dtgTransactionLogs.Size = New System.Drawing.Size(929, 830)
        Me.dtgTransactionLogs.TabIndex = 15
        '
        'Timer1
        '
        '
        'searchTxtBox
        '
        Me.searchTxtBox.Location = New System.Drawing.Point(1625, 33)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(206, 20)
        Me.searchTxtBox.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1589, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'dtgReceipt
        '
        Me.dtgReceipt.AllowUserToAddRows = False
        Me.dtgReceipt.AllowUserToDeleteRows = False
        Me.dtgReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgReceipt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgReceipt.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.dtgReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgReceipt.Location = New System.Drawing.Point(15, 70)
        Me.dtgReceipt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtgReceipt.Name = "dtgReceipt"
        Me.dtgReceipt.ReadOnly = True
        Me.dtgReceipt.RowHeadersWidth = 51
        Me.dtgReceipt.RowTemplate.Height = 24
        Me.dtgReceipt.Size = New System.Drawing.Size(866, 830)
        Me.dtgReceipt.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 922)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 55)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Total Sales Today:"
        '
        'totalLbl
        '
        Me.totalLbl.AutoSize = True
        Me.totalLbl.BackColor = System.Drawing.Color.Transparent
        Me.totalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLbl.ForeColor = System.Drawing.Color.Gray
        Me.totalLbl.Location = New System.Drawing.Point(553, 922)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(52, 55)
        Me.totalLbl.TabIndex = 20
        Me.totalLbl.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(432, 922)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 55)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "PHP"
        '
        'quantitySold
        '
        Me.quantitySold.AutoSize = True
        Me.quantitySold.BackColor = System.Drawing.Color.Transparent
        Me.quantitySold.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitySold.ForeColor = System.Drawing.Color.Gray
        Me.quantitySold.Location = New System.Drawing.Point(629, 977)
        Me.quantitySold.Name = "quantitySold"
        Me.quantitySold.Size = New System.Drawing.Size(52, 55)
        Me.quantitySold.TabIndex = 23
        Me.quantitySold.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 977)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(628, 55)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Total Products Sold Today:"
        '
        'TransactionLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1843, 1041)
        Me.Controls.Add(Me.quantitySold)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totalLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgReceipt)
        Me.Controls.Add(Me.searchTxtBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dtgTransactionLogs)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TransactionLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionLogs"
        CType(Me.dtgTransactionLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgTransactionLogs As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dtgReceipt As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents totalLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents quantitySold As Label
    Friend WithEvents Label4 As Label
End Class
