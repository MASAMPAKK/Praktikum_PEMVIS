Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Koneksi()
        cmd = New MySqlCommand("SELECT * FROM user WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        rd = cmd.ExecuteReader()
        If rd.Read() Then
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormTiket.user_id = rd("id_user")
            FormTiket.user_nama = rd("username")
            rd.Close()
            Me.Hide()
            FormTiket.Show()
        Else
            rd.Close()
            MessageBox.Show("Login Gagal. Cek kembali username/password", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        FormRegister.ShowDialog()
    End Sub
End Class
