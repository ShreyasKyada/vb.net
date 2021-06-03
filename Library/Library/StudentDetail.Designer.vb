<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentDetail
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
        Me.lblRno = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSem = New System.Windows.Forms.Label()
        Me.lblBid = New System.Windows.Forms.Label()
        Me.txtRno = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtSem = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRno
        '
        Me.lblRno.AutoSize = True
        Me.lblRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRno.Location = New System.Drawing.Point(26, 24)
        Me.lblRno.Name = "lblRno"
        Me.lblRno.Size = New System.Drawing.Size(139, 39)
        Me.lblRno.TabIndex = 0
        Me.lblRno.Text = "Roll No "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblName.Location = New System.Drawing.Point(26, 233)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(117, 39)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name "
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblSem.Location = New System.Drawing.Point(26, 162)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(162, 39)
        Me.lblSem.TabIndex = 2
        Me.lblSem.Text = "Semester"
        '
        'lblBid
        '
        Me.lblBid.AutoSize = True
        Me.lblBid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBid.Location = New System.Drawing.Point(26, 95)
        Me.lblBid.Name = "lblBid"
        Me.lblBid.Size = New System.Drawing.Size(133, 39)
        Me.lblBid.TabIndex = 2
        Me.lblBid.Text = "Book Id"
        '
        'txtRno
        '
        Me.txtRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtRno.Location = New System.Drawing.Point(194, 21)
        Me.txtRno.Name = "txtRno"
        Me.txtRno.Size = New System.Drawing.Size(384, 45)
        Me.txtRno.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtId.Location = New System.Drawing.Point(194, 89)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(384, 45)
        Me.txtId.TabIndex = 2
        '
        'txtSem
        '
        Me.txtSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtSem.Location = New System.Drawing.Point(194, 159)
        Me.txtSem.Name = "txtSem"
        Me.txtSem.Size = New System.Drawing.Size(384, 45)
        Me.txtSem.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.AcceptsTab = True
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtName.Location = New System.Drawing.Point(194, 230)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(384, 45)
        Me.txtName.TabIndex = 4
        '
        'dgvStudent
        '
        Me.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(636, 21)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.ReadOnly = True
        Me.dgvStudent.RowTemplate.Height = 24
        Me.dgvStudent.Size = New System.Drawing.Size(698, 606)
        Me.dgvStudent.TabIndex = 8
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnInsert.Location = New System.Drawing.Point(33, 314)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(545, 88)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(33, 424)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(545, 88)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnDelete.Location = New System.Drawing.Point(33, 532)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(545, 88)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'studentDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 639)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSem)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtRno)
        Me.Controls.Add(Me.lblBid)
        Me.Controls.Add(Me.lblSem)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRno)
        Me.Name = "studentDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentDetail (Insert, Update and Delete)"
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRno As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents lblBid As System.Windows.Forms.Label
    Friend WithEvents txtRno As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtSem As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents dgvStudent As System.Windows.Forms.DataGridView
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
