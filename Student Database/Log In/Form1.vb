Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Log In.mdb"
        Dim sql As String
        sql = "select * from login where User_Name='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "' and Account_Type='" & ComboBox1.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            If (ComboBox1.Text = "User") Then
                Form2.ModifyToolStripMenuItem.Enabled = False
                Form2.DeleteToolStripMenuItem.Enabled = False
            End If
            MsgBox("Welcome " & TextBox1.Text)
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("User Name or Password not correct")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("User")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
