Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student Database.mdb"
        con.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "insert into Student values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        cmd = New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Record Inserted Successfully.........")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class