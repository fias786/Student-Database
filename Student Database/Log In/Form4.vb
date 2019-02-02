Imports System.Data
Imports System.Data.OleDb
Public Class Form4
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim pointer As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Student Database.mdb"
        con.Open()
        da = New OleDbDataAdapter("select * from Student", con)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        pointer = 0
        getRecords()
    End Sub

    Private Sub getRecords()
        TextBox1.Text = ds.Tables(0).Rows(pointer)(0)
        TextBox2.Text = ds.Tables(0).Rows(pointer)(1)
        TextBox3.Text = ds.Tables(0).Rows(pointer)(2)
        TextBox4.Text = ds.Tables(0).Rows(pointer)(3)
        TextBox5.Text = ds.Tables(0).Rows(pointer)(4)
        TextBox6.Text = ds.Tables(0).Rows(pointer)(5)
        TextBox7.Text = ds.Tables(0).Rows(pointer)(6)
        TextBox8.Text = ds.Tables(0).Rows(pointer)(7)
    End Sub

    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        pointer = 0
        getRecords()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If (pointer < ds.Tables(0).Rows.Count - 1) Then
            pointer = pointer + 1
            getRecords()
        Else
            MsgBox("This is Last Records....")
        End If
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        If (pointer > 0) Then
            pointer = pointer - 1
            getRecords()
        Else
            MsgBox("This is First Records....")
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        pointer = ds.Tables(0).Rows.Count - 1
        getRecords()
    End Sub
End Class