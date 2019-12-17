Imports MySql.Data.MySqlClient

Public Class FormPeminjaman

    Private Sub btnanggota_Click(sender As Object, e As EventArgs) Handles btnanggota.Click
        FormAnggota.from = "peminjaman"
        FormAnggota.ShowDialog()
    End Sub

    Private Sub btnbuku_Click(sender As Object, e As EventArgs) Handles btnbuku.Click
        FormBuku.from = "peminjaman"
        FormBuku.ShowDialog()
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * FROM tb_keranjang"
        Dim da As New MySqlDataAdapter(query, konek)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            dgv.DataSource = ds.Tables(0)
            dgv.Refresh()
        Else
            dgv.DataSource = Nothing
        End If
        If dgv.RowCount > 0 Then
            'judulgrid()
        End If
    End Sub
    Sub querytambah()
        Dim q As String = "INSERT INTO tb_keranjang VALUES (@kd_buku, @judul, @tgl_kembali)"
        Querykeranjang(q, tbkdbuku.Text, tbjudulbuku.Text.ToUpper, dtpkembalibuku.Value)
        MsgBox("Berhasil tambah data!", MsgBoxStyle.Information, "Informasi")
        isigrid()
    End Sub
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        querytambah()
    End Sub
End Class