<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDetail
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
        Me.dgvBookIssue = New System.Windows.Forms.DataGridView()
        Me.lblRno = New System.Windows.Forms.Label()
        Me.txtRno = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvBookIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBookIssue
        '
        Me.dgvBookIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookIssue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBookIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookIssue.Location = New System.Drawing.Point(583, 12)
        Me.dgvBookIssue.Name = "dgvBookIssue"
        Me.dgvBookIssue.ReadOnly = True
        Me.dgvBookIssue.RowTemplate.Height = 24
        Me.dgvBookIssue.Size = New System.Drawing.Size(561, 395)
        Me.dgvBookIssue.TabIndex = 21
        '
        'lblRno
        '
        Me.lblRno.AutoSize = True
        Me.lblRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRno.Location = New System.Drawing.Point(12, 97)
        Me.lblRno.Name = "lblRno"
        Me.lblRno.Size = New System.Drawing.Size(139, 39)
        Me.lblRno.TabIndex = 22
        Me.lblRno.Text = "Roll No "
        '
        'txtRno
        '
        Me.txtRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtRno.Location = New System.Drawing.Point(171, 97)
        Me.txtRno.Name = "txtRno"
        Me.txtRno.Size = New System.Drawing.Size(359, 45)
        Me.txtRno.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(19, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(511, 92)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 419)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRno)
        Me.Controls.Add(Me.lblRno)
        Me.Controls.Add(Me.dgvBookIssue)
        Me.Name = "SearchDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvBookIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBookIssue As System.Windows.Forms.DataGridView
    Friend WithEvents lblRno As System.Windows.Forms.Label
    Friend WithEvents txtRno As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
