<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetail
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblBid = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnDelete.Location = New System.Drawing.Point(26, 527)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(545, 88)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(26, 419)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(545, 88)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnInsert.Location = New System.Drawing.Point(26, 309)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(545, 88)
        Me.btnInsert.TabIndex = 17
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'dgvBook
        '
        Me.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(629, 16)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.RowTemplate.Height = 24
        Me.dgvBook.Size = New System.Drawing.Size(698, 606)
        Me.dgvBook.TabIndex = 20
        '
        'txtDept
        '
        Me.txtDept.AcceptsTab = True
        Me.txtDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtDept.Location = New System.Drawing.Point(212, 216)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(359, 45)
        Me.txtDept.TabIndex = 16
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtName.Location = New System.Drawing.Point(212, 131)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(359, 45)
        Me.txtName.TabIndex = 15
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtId.Location = New System.Drawing.Point(212, 47)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(359, 45)
        Me.txtId.TabIndex = 12
        '
        'lblBid
        '
        Me.lblBid.AutoSize = True
        Me.lblBid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBid.Location = New System.Drawing.Point(19, 53)
        Me.lblBid.Name = "lblBid"
        Me.lblBid.Size = New System.Drawing.Size(133, 39)
        Me.lblBid.TabIndex = 14
        Me.lblBid.Text = "Book Id"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblDept.Location = New System.Drawing.Point(12, 218)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(194, 39)
        Me.lblDept.TabIndex = 13
        Me.lblDept.Text = "Department"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblName.Location = New System.Drawing.Point(19, 134)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(117, 39)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name "
        '
        'BookDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 639)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblBid)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblName)
        Me.Name = "BookDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookDetail"
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents dgvBook As System.Windows.Forms.DataGridView
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblBid As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
