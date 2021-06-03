Imports System.Data.OleDb
Imports System.Data

Public Class Report

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Programs\VB.NET\Library\Librarydb.mdb")

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display()
    End Sub

    Sub display()
        Try
            con.Open()
            Dim BookIssueDA As New OleDbDataAdapter("select * from BookIssue", con)
            Dim str As Date = Today
            Dim ReportDA As New OleDbDataAdapter("SELECT StudentDetail.rollno, StudentDetail.s_name, StudentDetail.semester, StudentDetail.book_id From (BookIssue INNER JOIN StudentDetail ON BookIssue.rollno = StudentDetail.rollno) WHERE (BookIssue.return_date = #" & str.Month & "/" & str.Day & "/" & str.Year & "#)", con)
            Dim BookIssueDS As New DataSet
            Dim ReportDS As New DataSet
            BookIssueDS.Clear()
            ReportDS.Clear()
            ReportDA.Fill(ReportDS)
            BookIssueDA.Fill(BookIssueDS)
            dgvBookissue.DataSource = BookIssueDS.Tables(0)
            dgvReport.DataSource = ReportDS.Tables(0)
            txtBid.Text = ""
            txtINo.Text = ""
            txtRno.Text = ""
            mtbIssueDate.Text = ""
            mtbReturnDate.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            con.Open()
            Dim cmd As New OleDbCommand("insert into BookIssue values(" & txtINo.Text & "," & txtRno.Text & "," & txtBid.Text & ", #" & mtbIssueDate.Text & "#, #" & mtbReturnDate.Text & "#)", con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        display()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            con.Open()
            Dim cmd As New OleDbCommand("update BookIssue SET rollno = " & txtRno.Text & ", book_id = " & txtBid.Text & ", issue_date = #" & mtbIssueDate.Text & "#, return_date = #" & mtbReturnDate.Text & "# WHERE issue_no = " & txtINo.Text, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        display()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            con.Open()
            Dim cmd As New OleDbCommand("delete from BookIssue where issue_no = " & txtINo.Text, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        display()
    End Sub
End Class