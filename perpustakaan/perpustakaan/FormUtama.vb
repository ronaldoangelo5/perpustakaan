Public Class FormUtama

    Private Sub DataBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem.Click
        FormBuku.ShowDialog()
    End Sub

    Private Sub DataPenerbitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenerbitToolStripMenuItem.Click
        FormPenerbit.ShowDialog()
    End Sub

    Private Sub DataPengarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPengarangToolStripMenuItem.Click
        FormPengarang.ShowDialog()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class