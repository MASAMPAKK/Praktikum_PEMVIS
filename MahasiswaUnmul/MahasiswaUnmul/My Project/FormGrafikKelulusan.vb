Public Class FormGrafikKelulusan
    Public DataMahasiswa As DataGridView

    Private Sub FormGrafikKelulusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series.Clear()

        Dim series As New DataVisualization.Charting.Series("IPK Mahasiswa")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Column
        series.IsValueShownAsLabel = True

        For Each row As DataGridViewRow In DataMahasiswa.Rows
            If Not row.IsNewRow Then
                Dim nama As String = row.Cells(1).Value.ToString()

                ' Pastikan indeks IPK benar (kolom ke-4 adalah index 4)
                Dim ipkText As String = row.Cells(4).Value.ToString().Replace(",", ".") ' Mengganti koma jika ada
                Dim ipk As Double

                If Double.TryParse(ipkText, System.Globalization.NumberStyles.Any,
                                   System.Globalization.CultureInfo.InvariantCulture, ipk) Then
                    series.Points.AddXY(nama, ipk)
                End If
            End If
        Next

        Chart1.Series.Add(series)

        ' Label sumbu
        Chart1.ChartAreas(0).AxisX.Title = "Nama Mahasiswa"
        Chart1.ChartAreas(0).AxisY.Title = "IPK"

        ' Format sumbu Y
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.ChartAreas(0).AxisY.Maximum = 4
        Chart1.ChartAreas(0).AxisY.Interval = 0.5
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnLihatInfo_Click(sender As Object, e As EventArgs) Handles btnLihatInfo.Click
        Dim infoForm As New FormInformasiMahasiswa()
        infoForm.DataMahasiswa = Me.DataMahasiswa
        infoForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cetakForm As New FormCetakIjazah()
        cetakForm.DataMahasiswa = Me.DataMahasiswa
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
