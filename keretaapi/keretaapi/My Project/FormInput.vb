
Imports MySql.Data.MySqlClient

Public Class FormInput
    Public ModeEdit As Boolean = False

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Koneksi()
        If ModeEdit = False Then
            cmd = New MySqlCommand("INSERT INTO tiket_kereta(nama_penumpang, asal, tujuan, tanggal_berangkat, jam, harga) VALUES ('" & txtNama.Text & "', '" & txtAsal.Text & "', '" & txtTujuan.Text & "', '" & dtTanggal.Value.ToString("yyyy-MM-dd") & "', '" & txtJam.Text & "', '" & txtHarga.Text & "')", conn)
        Else
            cmd = New MySqlCommand("UPDATE tiket_kereta SET nama_penumpang='" & txtNama.Text & "', asal='" & txtAsal.Text & "', tujuan='" & txtTujuan.Text & "', tanggal_berangkat='" & dtTanggal.Value.ToString("yyyy-MM-dd") & "', jam='" & txtJam.Text & "', harga='" & txtHarga.Text & "' WHERE id_tiket=" & txtID.Text, conn)
        End If
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan!")
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
