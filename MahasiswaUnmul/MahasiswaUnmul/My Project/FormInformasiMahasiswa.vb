Public Class FormInformasiMahasiswa
    Public DataMahasiswa As DataGridView

    Private Sub FormInformasiMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("NIM", "NIM")
        DataGridView1.Columns.Add("Nama", "Nama")
        DataGridView1.Columns.Add("Prodi", "Prodi")
        DataGridView1.Columns.Add("IPK", "IPK")
        DataGridView1.Columns.Add("Tahun", "Tahun Lulus")
        DataGridView1.Columns.Add("JK", "Jenis Kelamin")
        DataGridView1.Columns.Add("Foto", "Foto Path")

        LoadData()
    End Sub

    Sub LoadData()
        DataGridView1.Rows.Clear()

        If DataMahasiswa IsNot Nothing Then
            For Each row As DataGridViewRow In DataMahasiswa.Rows
                If Not row.IsNewRow Then
                    Dim data() As String = {
                        row.Cells(0).Value.ToString(),
                        row.Cells(1).Value.ToString(),
                        row.Cells(2).Value.ToString(),
                        row.Cells(3).Value.ToString(),
                        row.Cells(4).Value.ToString(),
                        row.Cells(5).Value.ToString(),
                        row.Cells(6).Value.ToString()
                    }
                    DataGridView1.Rows.Add(data)
                End If
            Next
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim keyword As String = txtCari.Text.ToLower()

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Visible = True

            If Not row.IsNewRow Then
                Dim nim As String = row.Cells(0).Value.ToString().ToLower()
                Dim nama As String = row.Cells(1).Value.ToString().ToLower()

                ' Tampilkan baris jika nim atau nama mengandung keyword
                If Not (nim.Contains(keyword) Or nama.Contains(keyword)) Then
                    row.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)
            LabelNIM.Text = "NIM: " & row.Cells(0).Value.ToString()
            LabelNama.Text = "Nama: " & row.Cells(1).Value.ToString()
            LabelProdi.Text = "Prodi: " & row.Cells(2).Value.ToString()
            LabelIPK.Text = "IPK: " & row.Cells(3).Value.ToString()
            LabelTahun.Text = "Tahun Lulus: " & row.Cells(4).Value.ToString()
            LabelJK.Text = "Jenis Kelamin: " & row.Cells(5).Value.ToString()

            Dim fotoPath As String = row.Cells(6).Value.ToString()
            If System.IO.File.Exists(fotoPath) Then
                PictureBox1.Image = Image.FromFile(fotoPath)
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm1 As New Form1()
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub btnGrafik_Click(sender As Object, e As EventArgs) Handles btnGrafik.Click
        Dim grafikForm As New FormGrafikKelulusan()
        grafikForm.DataMahasiswa = Me.DataGridView1
        grafikForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cetakForm As New FormCetakIjazah()
        cetakForm.DataMahasiswa = Me.DataMahasiswa ' Kirim DataGridView dari FormGrafikKelulusan
        cetakForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
