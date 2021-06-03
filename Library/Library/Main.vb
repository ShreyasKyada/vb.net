Public Class Main

    Private Sub msStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msStudent.Click
        studentDetail.Show()
    End Sub

    Private Sub msBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msBook.Click
        BookDetail.Show()
    End Sub

    Private Sub msReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msReport.Click
        Report.Show()
    End Sub

    Private Sub SearchStudentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudentDetailsToolStripMenuItem.Click
        SearchDetail.Show()
    End Sub
End Class
