
Imports System.Data
Imports System.Data.OleDb
Public Class Form7
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim pointer As Integer
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If (btn_update.Text = "Update") Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            btn_update.Text = "Save"
        Else
            Dim sql As String
            sql = "update Student set Unique_ID='" & TextBox1.Text & "',Name='" & TextBox2.Text & "',Address='" & TextBox3.Text & "',Phone_No='" & TextBox4.Text & "',Gender='" & TextBox5.Text & "',Email='" & TextBox6.Text & "',Religion='" & TextBox7.Text & "',Nationality='" & TextBox8.Text & "'where Unique_ID='" & TextBox1.Text & "'"
            Dim md As New OleDbCommand(sql, con)
            md.ExecuteNonQuery()
            da = New OleDbDataAdapter("select * from Student", con)
            ds = New DataSet()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            pointer = 0
            getRecords()
            btn_update.Text = "Update"
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
        End If
    End Sub
End Class