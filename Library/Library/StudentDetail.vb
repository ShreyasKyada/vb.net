Imports System.Data.OleDb
Imports System.Data

Public Class studentDetail
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Programs\VB.NET\Library\Librarydb.mdb")

    Private Sub studentDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display()
    End Sub

    Sub display()
        Try
            con.Open()
            Dim da As New OleDbDataAdapter("select * from StudentDetail", con)
            Dim ds As New DataSet
            ds.Clear()
            da.Fill(ds)
            dgvStudent.DataSource = ds.Tables(0)
            txtId.Text = ""
            txtName.Text = ""
            txtRno.Text = ""
            txtSem.Text = ""
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
            Dim cmd As New OleDbCommand("insert into StudentDetail values(" & txtRno.Text & ",'" & txtName.Text & "'," & txtSem.Text & "," & txtId.Text & ")", con)
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
            Dim cmd As New OleDbCommand("update StudentDetail set s_name='" & txtName.Text & "', semester=" & txtSem.Text & ", book_id=" & txtId.Text & " Where rollno=" & txtRno.Text, con)
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
            Dim cmd As New OleDbCommand("delete from StudentDetail where rollno = " & txtRno.Text, con)
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