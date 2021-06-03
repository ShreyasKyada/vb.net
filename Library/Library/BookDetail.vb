Imports System.Data.OleDb
Imports System.Data

Public Class BookDetail
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Programs\VB.NET\Library\Librarydb.mdb")

    Private Sub BookDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display()
    End Sub

    Sub display()
        Try
            con.Open()
            Dim da As New OleDbDataAdapter("select * from BookDetail", con)
            Dim ds As New DataSet
            ds.Clear()
            da.Fill(ds)
            dgvBook.DataSource = ds.Tables(0)
            txtId.Text = ""
            txtName.Text = ""
            txtDept.Text = ""
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
            Dim cmd As New OleDbCommand("insert into BookDetail values(" & txtId.Text & ",'" & txtName.Text & "','" & txtDept.Text & "')", con)
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
            Dim cmd As New OleDbCommand("update BookDetail set b_name = '" & txtName.Text & "', department = '" & txtDept.Text & "' where book_id = " & txtId.Text, con)
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
            Dim cmd As New OleDbCommand("delete from BookDetail where book_id = " & txtId.Text, con)
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