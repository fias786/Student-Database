Imports System.Data
Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New OleDbCommand("delete * from Student where Unique_ID='" & TextBox1.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted Successfully....")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        sql = "select * from Student where Unique_ID='" & TextBox1.Text & "'"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            lbl_name.Text = ds.Tables(0).Rows(0)(1)
            lbl_add.Text = ds.Tables(0).Rows(0)(2)
            lbl_phone.Text = ds.Tables(0).Rows(0)(3)
            lbl_gender.Text = ds.Tables(0).Rows(0)(4)
            lbl_mail.Text = ds.Tables(0).Rows(0)(5)
            lbl_religion.Text = ds.Tables(0).Rows(0)(6)
            lbl_nation.Text = ds.Tables(0).Rows(0)(7)
        Else
            MsgBox("Record Not Found....")
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student Database.mdb"
        con.Open()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class