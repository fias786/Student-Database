Imports System.Data
Imports System.Data.OleDb
Public Class Form6
    Dim con As New OleDbConnection

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student Database.mdb"
        con.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As OleDbDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        sql = "select Unique_ID,Name,Address,Phone_No,Gender,Religion,Nationality from Student where Name like '%" & TextBox1.Text & "%'"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record Not Found......")
        End If
    End Sub
End Class