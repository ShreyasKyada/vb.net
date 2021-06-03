Imports System.Data.OleDb
Imports System.Data

Public Class SearchDetail

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Programs\VB.NET\Library\Librarydb.mdb")

    Private Sub SearchDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display()
    End Sub

    Sub display()
        Try
            con.Open()
            Dim da As New OleDbDataAdapter("select * from BookIssue", con)
            Dim ds As New DataSet
            da.Fill(ds)
            dgvBookIssue.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT StudentDetail.rollno, StudentDetail.s_name, StudentDetail.semester, StudentDetail.book_id FROM (BookIssue INNER JOIN StudentDetail ON BookIssue.rollno = StudentDetail.rollno) WHERE(BookIssue.rollno = " & txtRno.Text & ")", con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            reader.Read()
            MessageBox.Show("Roll No = " & reader(0) & vbNewLine & "Name = " & reader(1) & vbNewLine & "Semestrer = " & reader(2) & vbNewLine & "Book Id = " & reader(3))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class