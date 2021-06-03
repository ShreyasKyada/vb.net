<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.NdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStudentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QueryToolStripMenuItem, Me.NdToolStripMenuItem, Me.RdToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1004, 43)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QueryToolStripMenuItem
        '
        Me.QueryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msBook, Me.msStudent})
        Me.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem"
        Me.QueryToolStripMenuItem.Size = New System.Drawing.Size(59, 39)
        Me.QueryToolStripMenuItem.Text = "1st"
        '
        'msStudent
        '
        Me.msStudent.Name = "msStudent"
        Me.msStudent.Size = New System.Drawing.Size(499, 40)
        Me.msStudent.Text = "StudentDetail (Insert, Update, Delete)"
        '
        'msBook
        '
        Me.msBook.Name = "msBook"
        Me.msBook.Size = New System.Drawing.Size(499, 40)
        Me.msBook.Text = "BookDetail (Insert, Update, Delete)"
        '
        'NdToolStripMenuItem
        '
        Me.NdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msReport})
        Me.NdToolStripMenuItem.Name = "NdToolStripMenuItem"
        Me.NdToolStripMenuItem.Size = New System.Drawing.Size(69, 39)
        Me.NdToolStripMenuItem.Text = "2nd"
        '
        'msReport
        '
        Me.msReport.Name = "msReport"
        Me.msReport.Size = New System.Drawing.Size(525, 40)
        Me.msReport.Text = "Insert, Update, Delete (generate report)"
        '
        'RdToolStripMenuItem
        '
        Me.RdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchStudentDetailsToolStripMenuItem})
        Me.RdToolStripMenuItem.Name = "RdToolStripMenuItem"
        Me.RdToolStripMenuItem.Size = New System.Drawing.Size(64, 39)
        Me.RdToolStripMenuItem.Text = "3rd"
        '
        'SearchStudentDetailsToolStripMenuItem
        '
        Me.SearchStudentDetailsToolStripMenuItem.Name = "SearchStudentDetailsToolStripMenuItem"
        Me.SearchStudentDetailsToolStripMenuItem.Size = New System.Drawing.Size(333, 40)
        Me.SearchStudentDetailsToolStripMenuItem.Text = "Search student details"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1004, 597)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchStudentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
