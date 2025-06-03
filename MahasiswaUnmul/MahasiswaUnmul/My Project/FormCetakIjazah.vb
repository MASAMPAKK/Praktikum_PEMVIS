Imports System.Drawing.Printing

Public Class FormCetakIjazah
    Public DataMahasiswa As DataGridView
    Private printNama As String = ""
    Private printNIM As String = ""
    Private printProdi As String = ""
    Private printTanggalLulus As String = ""
    Private printIPK As Double = 0
    Private printPredikat As String = ""

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            Dim nimCari As String = txtNIM.Text.Trim()
            If String.IsNullOrEmpty(nimCari) Then
                MessageBox.Show("Masukkan NIM terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim found As Boolean = False
            For Each row As DataGridViewRow In DataMahasiswa.Rows
                If Not row.IsNewRow AndAlso row.Cells("NIM").Value.ToString().Equals(nimCari, StringComparison.OrdinalIgnoreCase) Then
                    printNIM = row.Cells("NIM").Value.ToString()
                    printNama = row.Cells("Nama").Value.ToString()
                    printProdi = row.Cells("Prodi").Value.ToString()
                    printIPK = Convert.ToDouble(row.Cells("IPK").Value)
                    printTanggalLulus = row.Cells("Tahun").Value.ToString()
                    printPredikat = GetPredikat(printIPK)

                    lblNama.Text = printNama.ToUpper()
                    lblProdi.Text = printProdi
                    lblTgl.Text = FormatTanggal(printTanggalLulus)
                    lblPredikat.Text = printPredikat
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                MessageBox.Show("Data dengan NIM tersebut tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetFields()
        End Try
    End Sub

    Private Function GetPredikat(ipk As Double) As String
        If ipk >= 3.5 Then Return "Cumlaude"
        If ipk >= 3.0 Then Return "Sangat Memuaskan"
        Return "Memuaskan"
    End Function

    Private Function FormatTanggal(tanggal As String) As String
        Try
            Dim dt As DateTime = DateTime.Parse(tanggal)
            Return dt.ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("id-ID"))
        Catch
            Return tanggal
        End Try
    End Function

    Private Sub ResetFields()
        printNama = ""
        printNIM = ""
        printProdi = ""
        printTanggalLulus = ""
        printPredikat = ""

        lblNama.Text = "-"
        lblProdi.Text = "-"
        lblTgl.Text = "-"
        lblPredikat.Text = "-"
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrEmpty(printNIM) Then
            MessageBox.Show("Tidak ada data yang dapat dicetak. Cari data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Configure print document
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintDocument1.DefaultPageSettings.Margins = New Margins(100, 100, 100, 100)
            PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 827, 1169) ' A4 size in hundredths of an inch

            ' Create and configure preview dialog
            Dim previewDialog As New PrintPreviewDialog()
            previewDialog.Document = PrintDocument1
            previewDialog.WindowState = FormWindowState.Maximized
            previewDialog.PrintPreviewControl.StartPage = 0
            previewDialog.PrintPreviewControl.Zoom = 1.0
            previewDialog.Text = "Pratinjau Ijazah - " & printNama

            ' Show preview
            previewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            ' Set quality settings
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

            ' Font settings
            Dim fontHeader As New Font("Times New Roman", 18, FontStyle.Bold)
            Dim fontTitle As New Font("Times New Roman", 16, FontStyle.Bold)
            Dim fontBody As New Font("Times New Roman", 14)
            Dim fontBold As New Font("Times New Roman", 14, FontStyle.Bold)
            Dim fontName As New Font("Times New Roman", 16, FontStyle.Bold)

            Dim brush As New SolidBrush(Color.Black)
            Dim pageWidth As Integer = e.PageBounds.Width
            Dim yPos As Integer = e.MarginBounds.Top + 50

            ' Center alignment function
            Dim CenterText As Func(Of String, Font, Integer) = Function(text As String, font As Font)
                                                                   Dim textWidth As Integer = CInt(e.Graphics.MeasureString(text, font).Width)
                                                                   Return CInt((pageWidth - textWidth) / 2)
                                                               End Function

            ' Header
            e.Graphics.DrawString("KEMENTERIAN TWIN LIPS OPEROMASI", fontHeader, brush, CenterText("KEMENTERIAN TWIN LIPS OPEROMASI", fontHeader), yPos)
            yPos += 40
            e.Graphics.DrawString("UNIVERSITAS BIBIR KEMBAR", fontHeader, brush, CenterText("UNIVERSITAS BIBIR KEMBAR", fontHeader), yPos)
            yPos += 60

            ' Body
            e.Graphics.DrawString("Dengan ini menyatakan bahwa", fontTitle, brush, CenterText("Dengan ini menyatakan bahwa", fontTitle), yPos)
            yPos += 50

            ' Student info
            e.Graphics.DrawString(printNama.ToUpper(), fontName, brush, CenterText(printNama.ToUpper(), fontName), yPos)
            yPos += 40
            e.Graphics.DrawString("NIM: " & printNIM, fontBody, brush, CenterText("NIM: " & printNIM, fontBody), yPos)
            yPos += 50

            ' Program info
            e.Graphics.DrawString("Telah menyelesaikan studi dan memenuhi segala syarat", fontBody, brush, CenterText("Telah menyelesaikan studi dan memenuhi segala syarat", fontBody), yPos)
            yPos += 30
            e.Graphics.DrawString("pendidikan Strata Satu Program Studi " & printProdi, fontBody, brush, CenterText("pendidikan Strata Satu Program Studi " & printProdi, fontBody), yPos)
            yPos += 30
            e.Graphics.DrawString("Lulus pada Tahun " & printTanggalLulus, fontBody, brush, CenterText("Lulus pada tanggal " & printTanggalLulus, fontBody), yPos)
            yPos += 60

            ' Degree info
            e.Graphics.DrawString("Oleh sebab itu, kepadanya diberikan gelar", fontBody, brush, CenterText("Oleh sebab itu, kepadanya diberikan gelar", fontBody), yPos)
            yPos += 50
            e.Graphics.DrawString("SARJANA KOMPUTER (S.Kom.)", fontBold, brush, CenterText("SARJANA KOMPUTER (S.Kom.)", fontBold), yPos)
            yPos += 40
            e.Graphics.DrawString("Predikat: " & printPredikat, fontBody, brush, CenterText("Predikat: " & printPredikat, fontBody), yPos)
            yPos += 60

            ' Footer
            e.Graphics.DrawString("Dengan segala hak dan kewajiban yang melekat pada gelar tersebut.", fontBody, brush, CenterText("Dengan segala hak dan kewajiban yang melekat pada gelar tersebut.", fontBody), yPos)

            ' No more pages
            e.HasMorePages = False
        Catch ex As Exception
            MessageBox.Show("Error saat membuat preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formInput As New Form1()
        formInput.Show()
        Me.Hide()
    End Sub


    Private Sub btnGrafik_Click(sender As Object, e As EventArgs) Handles btnGrafik.Click
        Dim formGrafik As New FormGrafikKelulusan()
        formGrafik.DataMahasiswa = Me.DataMahasiswa ' Kirim data dari form cetak ke grafik
        formGrafik.Show()
        Me.Hide()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim infoForm As New FormInformasiMahasiswa()
        infoForm.DataMahasiswa = Me.DataMahasiswa ' Jika ingin kirim data juga
        infoForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class