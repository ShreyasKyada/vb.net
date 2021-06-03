<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.dgvBookissue = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblno = New System.Windows.Forms.Label()
        Me.lblRno = New System.Windows.Forms.Label()
        Me.lblBid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtINo = New System.Windows.Forms.TextBox()
        Me.txtRno = New System.Windows.Forms.TextBox()
        Me.txtBid = New System.Windows.Forms.TextBox()
        Me.mtbReturnDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbIssueDate = New System.Windows.Forms.MaskedTextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvBookissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBookissue
        '
        Me.dgvBookissue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookissue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBookissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookissue.Location = New System.Drawing.Point(588, 45)
        Me.dgvBookissue.Name = "dgvBookissue"
        Me.dgvBookissue.ReadOnly = True
        Me.dgvBookissue.RowTemplate.Height = 24
        Me.dgvBookissue.Size = New System.Drawing.Size(698, 299)
        Me.dgvBookissue.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(853, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Book isuue table"
        '
        'dgvReport
        '
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(588, 407)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(698, 298)
        Me.dgvReport.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(699, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(526, 29)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Detail of students who has return books today"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblno.Location = New System.Drawing.Point(12, 45)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(152, 39)
        Me.lblno.TabIndex = 25
        Me.lblno.Text = "Issue No"
        '
        'lblRno
        '
        Me.lblRno.AutoSize = True
        Me.lblRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRno.Location = New System.Drawing.Point(12, 109)
        Me.lblRno.Name = "lblRno"
        Me.lblRno.Size = New System.Drawing.Size(130, 39)
        Me.lblRno.TabIndex = 25
        Me.lblRno.Text = "Roll No"
        '
        'lblBid
        '
        Me.lblBid.AutoSize = True
        Me.lblBid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBid.Location = New System.Drawing.Point(12, 174)
        Me.lblBid.Name = "lblBid"
        Me.lblBid.Size = New System.Drawing.Size(133, 39)
        Me.lblBid.TabIndex = 25
        Me.lblBid.Text = "Book Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 39)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Issue Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 39)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Return Date"
        '
        'txtINo
        '
        Me.txtINo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtINo.Location = New System.Drawing.Point(236, 45)
        Me.txtINo.Name = "txtINo"
        Me.txtINo.Size = New System.Drawing.Size(315, 45)
        Me.txtINo.TabIndex = 26
        '
        'txtRno
        '
        Me.txtRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtRno.Location = New System.Drawing.Point(236, 109)
        Me.txtRno.Name = "txtRno"
        Me.txtRno.Size = New System.Drawing.Size(315, 45)
        Me.txtRno.TabIndex = 26
        '
        'txtBid
        '
        Me.txtBid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtBid.Location = New System.Drawing.Point(236, 174)
        Me.txtBid.Name = "txtBid"
        Me.txtBid.Size = New System.Drawing.Size(315, 45)
        Me.txtBid.TabIndex = 26
        '
        'mtbReturnDate
        '
        Me.mtbReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.mtbReturnDate.Location = New System.Drawing.Point(236, 299)
        Me.mtbReturnDate.Mask = "00/00/0000"
        Me.mtbReturnDate.Name = "mtbReturnDate"
        Me.mtbReturnDate.Size = New System.Drawing.Size(315, 45)
        Me.mtbReturnDate.TabIndex = 27
        Me.mtbReturnDate.ValidatingType = GetType(Date)
        '
        'mtbIssueDate
        '
        Me.mtbIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.mtbIssueDate.Location = New System.Drawing.Point(236, 240)
        Me.mtbIssueDate.Mask = "00/00/0000"
        Me.mtbIssueDate.Name = "mtbIssueDate"
        Me.mtbIssueDate.Size = New System.Drawing.Size(315, 45)
        Me.mtbIssueDate.TabIndex = 27
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnInsert.Location = New System.Drawing.Point(19, 407)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(532, 76)
        Me.btnInsert.TabIndex = 28
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(19, 520)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(532, 76)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnDelete.Location = New System.Drawing.Point(19, 629)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(532, 76)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 717)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.mtbIssueDate)
        Me.Controls.Add(Me.mtbReturnDate)
        Me.Controls.Add(Me.txtBid)
        Me.Controls.Add(Me.txtRno)
        Me.Controls.Add(Me.txtINo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBid)
        Me.Controls.Add(Me.lblRno)
        Me.Controls.Add(Me.lblno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBookissue)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.dgvBookissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBookissue As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents lblRno As System.Windows.Forms.Label
    Friend WithEvents lblBid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtINo As System.Windows.Forms.TextBox
    Friend WithEvents txtRno As System.Windows.Forms.TextBox
    Friend WithEvents txtBid As System.Windows.Forms.TextBox
    Friend WithEvents mtbReturnDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbIssueDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
