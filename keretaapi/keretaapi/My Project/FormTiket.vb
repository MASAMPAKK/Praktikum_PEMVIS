
Imports MySql.Data.MySqlClient

Public Class FormTiket
    Sub TampilData()
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tiket_kereta", conn)
        ds = New DataSet
        da.Fill(ds, "tiket_kereta")
        DataGridView1.DataSource = ds.Tables("tiket_kereta")
    End Sub

    Private Sub FormTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormInput.ModeEdit = False
        FormInput.ShowDialog()
        TampilData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            With FormInput
                .txtID.Text = DataGridView1.SelectedRows(0).Cells("id_tiket").Value.ToString()
                .txtNama.Text = DataGridView1.SelectedRows(0).Cells("nama_penumpang").Value.ToString()
                .txtAsal.Text = DataGridView1.SelectedRows(0).Cells("asal").Value.ToString()
                .txtTujuan.Text = DataGridView1.SelectedRows(0).Cells("tujuan").Value.ToString()
                .dtTanggal.Value = DataGridView1.SelectedRows(0).Cells("tanggal_berangkat").Value
                .txtJam.Text = DataGridView1.SelectedRows(0).Cells("jam").Value.ToString()
                .txtHarga.Text = DataGridView1.SelectedRows(0).Cells("harga").Value.ToString()
                .ModeEdit = True
                .ShowDialog()
            End With
            TampilData()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As String = DataGridView1.SelectedRows(0).Cells("id_tiket").Value.ToString()
            Call Koneksi()
            cmd = New MySqlCommand("DELETE FROM tiket_kereta WHERE id_tiket=" & id, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!")
            TampilData()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tiket_kereta WHERE nama_penumpang LIKE '%" & txtCari.Text & "%' OR tujuan LIKE '%" & txtCari.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "tiket_kereta")
        DataGridView1.DataSource = ds.Tables("tiket_kereta")
    End Sub
End Class
