Imports System.Data
Imports System.Data.OleDb

Public Class Form8
    Dim con As New OleDbConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Log In.mdb"
        con.Open()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sql As String
        sql = "select * from login where User_Name='" & TextBox4.Text & "' and Password='" & TextBox3.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            Dim sql1 As String
            sql1 = "update login set Password='" & TextBox5.Text & "'"
            Dim md As New OleDbCommand(sql1, con)
            md.ExecuteNonQuery()
            da = New OleDbDataAdapter("select * from login", con)
            ds = New DataSet()
            da.Fill(ds)
            MsgBox("New password has been set")
            Me.Hide()
        Else
            MsgBox("Previous password not match")
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

  
End Class