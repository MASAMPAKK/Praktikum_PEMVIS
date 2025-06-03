<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInformasiMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelJK = New System.Windows.Forms.Label()
        Me.LabelTahun = New System.Windows.Forms.Label()
        Me.LabelProdi = New System.Windows.Forms.Label()
        Me.LabelIPK = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelNIM = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelJK
        '
        Me.LabelJK.AutoSize = True
        Me.LabelJK.Location = New System.Drawing.Point(232, 152)
        Me.LabelJK.Name = "LabelJK"
        Me.LabelJK.Size = New System.Drawing.Size(71, 13)
        Me.LabelJK.TabIndex = 42
        Me.LabelJK.Text = "Jenis Kelamin"
        '
        'LabelTahun
        '
        Me.LabelTahun.AutoSize = True
        Me.LabelTahun.Location = New System.Drawing.Point(232, 120)
        Me.LabelTahun.Name = "LabelTahun"
        Me.LabelTahun.Size = New System.Drawing.Size(66, 13)
        Me.LabelTahun.TabIndex = 30
        Me.LabelTahun.Text = "Tahun Lulus"
        '
        'LabelProdi
        '
        Me.LabelProdi.AutoSize = True
        Me.LabelProdi.Location = New System.Drawing.Point(232, 66)
        Me.LabelProdi.Name = "LabelProdi"
        Me.LabelProdi.Size = New System.Drawing.Size(31, 13)
        Me.LabelProdi.TabIndex = 29
        Me.LabelProdi.Text = "Prodi"
        '
        'LabelIPK
        '
        Me.LabelIPK.AutoSize = True
        Me.LabelIPK.Location = New System.Drawing.Point(232, 92)
        Me.LabelIPK.Name = "LabelIPK"
        Me.LabelIPK.Size = New System.Drawing.Size(24, 13)
        Me.LabelIPK.TabIndex = 28
        Me.LabelIPK.Text = "IPK"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(232, 40)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(35, 13)
        Me.LabelNama.TabIndex = 27
        Me.LabelNama.Text = "Nama"
        '
        'LabelNIM
        '
        Me.LabelNIM.AutoSize = True
        Me.LabelNIM.Location = New System.Drawing.Point(232, 15)
        Me.LabelNIM.Name = "LabelNIM"
        Me.LabelNIM.Size = New System.Drawing.Size(27, 13)
        Me.LabelNIM.TabIndex = 26
        Me.LabelNIM.Text = "NIM"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(191, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 254)
        Me.DataGridView1.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(8, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 426)
        Me.Panel1.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.btnGrafik)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(11, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(154, 171)
        Me.Panel3.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Ijazah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Informasi Mahasiswa"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnGrafik
        '
        Me.btnGrafik.Location = New System.Drawing.Point(3, 55)
        Me.btnGrafik.Name = "btnGrafik"
        Me.btnGrafik.Size = New System.Drawing.Size(148, 23)
        Me.btnGrafik.TabIndex = 7
        Me.btnGrafik.Text = "Grafik"
        Me.btnGrafik.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MahasiswaUnmul.My.Resources.Resources.images
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(497, 158)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(113, 20)
        Me.txtCari.TabIndex = 43
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(416, 156)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 44
        Me.btnCari.Text = "cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(628, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Red
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.Location = New System.Drawing.Point(50, 357)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 36
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormInformasiMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.LabelJK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelTahun)
        Me.Controls.Add(Me.LabelProdi)
        Me.Controls.Add(Me.LabelIPK)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelNIM)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInformasiMahasiswa"
        Me.Text = "FormInformasiMahasiswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelJK As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTahun As Label
    Friend WithEvents LabelProdi As Label
    Friend WithEvents LabelIPK As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelNIM As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnGrafik As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnKeluar As Button
End Class
