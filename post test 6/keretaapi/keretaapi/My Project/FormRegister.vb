Imports MySql.Data.MySqlClient

Public Class FormRegister
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Koneksi()
        cmd = New MySqlCommand("INSERT INTO user (username, password) VALUES (@username, @password)", conn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKembali.Click

    End Sub

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
