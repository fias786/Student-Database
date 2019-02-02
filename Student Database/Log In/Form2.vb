Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.MdiParent = Me
        Form4.MdiParent = Me
        Form5.MdiParent = Me
        Form6.MdiParent = Me
        Form7.MdiParent = Me
        Form8.MdiParent = Me
    End Sub

    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click
        Form3.Show()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
    End Sub

    Private Sub DisplayAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayAllToolStripMenuItem.Click
        Form3.Hide()
        Form4.Show()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Show()
        Form7.Hide()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Form3.Hide()
        Form4.Hide()
        Form5.Show()
        Form6.Hide()
        Form7.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
        Form8.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub
End Class