<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakIjazah
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.lblPredikat = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 426)
        Me.Panel1.TabIndex = 25
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
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(236, 37)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(202, 20)
        Me.txtNIM.TabIndex = 26
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(236, 63)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(111, 23)
        Me.btnCari.TabIndex = 27
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(244, 113)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(39, 13)
        Me.lblNama.TabIndex = 28
        Me.lblNama.Text = "Label1"
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(353, 63)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(111, 23)
        Me.btnCetak.TabIndex = 29
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(243, 174)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(39, 13)
        Me.lblTgl.TabIndex = 30
        Me.lblTgl.Text = "Label1"
        '
        'lblProdi
        '
        Me.lblProdi.AutoSize = True
        Me.lblProdi.Location = New System.Drawing.Point(244, 140)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.Size = New System.Drawing.Size(39, 13)
        Me.lblProdi.TabIndex = 31
        Me.lblProdi.Text = "Label1"
        '
        'lblPredikat
        '
        Me.lblPredikat.AutoSize = True
        Me.lblPredikat.Location = New System.Drawing.Point(244, 205)
        Me.lblPredikat.Name = "lblPredikat"
        Me.lblPredikat.Size = New System.Drawing.Size(39, 13)
        Me.lblPredikat.TabIndex = 32
        Me.lblPredikat.Text = "Label1"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Red
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.Location = New System.Drawing.Point(49, 351)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 33
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormCetakIjazah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPredikat)
        Me.Controls.Add(Me.lblProdi)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCetakIjazah"
        Me.Text = "FormCetakIjazah"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnGrafik As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lblNama As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btnKeluar As Button
End Class
