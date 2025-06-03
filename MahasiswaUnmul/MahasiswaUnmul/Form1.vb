Public Class Form1

    Dim selectedIndex As Integer = -1
    Dim fotoPath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("NIM", "NIM")
        DataGridView1.Columns.Add("Nama", "Nama")
        DataGridView1.Columns.Add("JenisKelamin", "Jenis Kelamin")
        DataGridView1.Columns.Add("Prodi", "Prodi")
        DataGridView1.Columns.Add("IPK", "IPK")
        DataGridView1.Columns.Add("Tahun", "Tahun Lulus")
        DataGridView1.Columns.Add("Foto", "Foto Path")

        RefreshDataGrid()
    End Sub

    Private Sub RefreshDataGrid()
        DataGridView1.Rows.Clear()
        For Each mhs In ListMahasiswa
            DataGridView1.Rows.Add(mhs.NIM, mhs.Nama, mhs.JenisKelamin, mhs.Prodi, mhs.IPK, mhs.TahunLulus, mhs.FotoPath)
        Next
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            fotoPath = ofd.FileName
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNIM.Text = "" Or txtNama.Text = "" Then
            MsgBox("Lengkapi data!")
            Return
        End If

        ' Validasi NIM
        If Not IsNumeric(txtNIM.Text) OrElse txtNIM.Text.Length <> 7 Then
            MsgBox("NIM harus 7 digit angka.")
            Return
        End If

        ' Validasi IPK
        Dim ipk As Double
        If Not Double.TryParse(txtIPK.Text, ipk) OrElse ipk < 0 Or ipk > 4 Then
            MsgBox("IPK harus angka antara 0 dan 4.")
            Return
        End If

        ' Validasi Tahun
        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text, tahun) OrElse tahun > Date.Now.Year Then
            MsgBox("Tahun lulus tidak valid.")
            Return
        End If

        ' Validasi Jenis Kelamin
        Dim jk As String = ""
        If rbLaki.Checked Then
            jk = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            jk = "Perempuan"
        Else
            MsgBox("Pilih jenis kelamin.")
            Return
        End If

        ' Tambah ke ListMahasiswa
        Dim mhsBaru As New Mahasiswa With {
            .NIM = txtNIM.Text,
            .Nama = txtNama.Text,
            .JenisKelamin = jk,
            .Prodi = txtProdi.Text,
            .IPK = ipk,
            .TahunLulus = tahun,
            .FotoPath = fotoPath
        }

        ListMahasiswa.Add(mhsBaru)
        RefreshDataGrid()
        ClearForm()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedIndex >= 0 AndAlso selectedIndex < ListMahasiswa.Count Then

            Dim jk As String = ""
            If rbLaki.Checked Then
                jk = "Laki-laki"
            ElseIf rbPerempuan.Checked Then
                jk = "Perempuan"
            Else
                MsgBox("Pilih jenis kelamin.")
                Return
            End If

            Dim ipk As Double
            If Not Double.TryParse(txtIPK.Text, ipk) OrElse ipk < 0 Or ipk > 4 Then
                MsgBox("IPK harus angka antara 0 dan 4.")
                Return
            End If

            Dim tahun As Integer
            If Not Integer.TryParse(txtTahun.Text, tahun) OrElse tahun > Date.Now.Year Then
                MsgBox("Tahun lulus tidak valid.")
                Return
            End If

            ' Update data ListMahasiswa
            With ListMahasiswa(selectedIndex)
                .NIM = txtNIM.Text
                .Nama = txtNama.Text
                .JenisKelamin = jk
                .Prodi = txtProdi.Text
                .IPK = ipk
                .TahunLulus = tahun
                .FotoPath = fotoPath
            End With

            RefreshDataGrid()
            ClearForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedIndex >= 0 AndAlso selectedIndex < ListMahasiswa.Count Then
            ListMahasiswa.RemoveAt(selectedIndex)
            RefreshDataGrid()
            ClearForm()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < ListMahasiswa.Count Then
            selectedIndex = e.RowIndex
            Dim mhs = ListMahasiswa(selectedIndex)

            txtNIM.Text = mhs.NIM
            txtNama.Text = mhs.Nama

            If mhs.JenisKelamin = "Laki-laki" Then
                rbLaki.Checked = True
            ElseIf mhs.JenisKelamin = "Perempuan" Then
                rbPerempuan.Checked = True
            Else
                rbLaki.Checked = False
                rbPerempuan.Checked = False
            End If

            txtProdi.Text = mhs.Prodi
            txtIPK.Text = mhs.IPK.ToString()
            txtTahun.Text = mhs.TahunLulus.ToString()
            fotoPath = mhs.FotoPath

            If System.IO.File.Exists(fotoPath) Then
                PictureBox1.Image = Image.FromFile(fotoPath)
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub

    Sub ClearForm()
        txtNIM.Clear()
        txtNama.Clear()
        txtProdi.Clear()
        txtIPK.Clear()
        txtTahun.Clear()
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        PictureBox1.Image = Nothing
        fotoPath = ""
        selectedIndex = -1
    End Sub

    Private Sub btnGrafik_Click(sender As Object, e As EventArgs) Handles btnGrafik.Click
        Dim grafikForm As New FormGrafikKelulusan()
        grafikForm.DataMahasiswa = Me.DataGridView1
        grafikForm.Show()
        Me.Hide()
    End Sub

    ' Validasi input NIM hanya angka
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi input IPK hanya angka dan titik
    Private Sub txtIPK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPK.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLihatInfo_Click(sender As Object, e As EventArgs) Handles btnLihatInfo.Click
        Dim infoForm As New FormInformasiMahasiswa()
        infoForm.DataMahasiswa = Me.DataGridView1
        infoForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formCetak As New FormCetakIjazah()
        formCetak.DataMahasiswa = Me.DataGridView1
        formCetak.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
