<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAsal = New System.Windows.Forms.TextBox()
        Me.txtTujuan = New System.Windows.Forms.TextBox()
        Me.txtJam = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(170, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(551, 22)
        Me.txtID.TabIndex = 0
        Me.txtID.Visible = False
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(170, 49)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(551, 22)
        Me.txtNama.TabIndex = 1
        '
        'txtAsal
        '
        Me.txtAsal.Location = New System.Drawing.Point(170, 93)
        Me.txtAsal.Name = "txtAsal"
        Me.txtAsal.Size = New System.Drawing.Size(551, 22)
        Me.txtAsal.TabIndex = 2
        '
        'txtTujuan
        '
        Me.txtTujuan.Location = New System.Drawing.Point(170, 136)
        Me.txtTujuan.Name = "txtTujuan"
        Me.txtTujuan.Size = New System.Drawing.Size(551, 22)
        Me.txtTujuan.TabIndex = 3
        '
        'txtJam
        '
        Me.txtJam.Location = New System.Drawing.Point(170, 224)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.Size = New System.Drawing.Size(551, 22)
        Me.txtJam.TabIndex = 5
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(170, 264)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(551, 22)
        Me.txtHarga.TabIndex = 4
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(170, 180)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(551, 22)
        Me.dtTanggal.TabIndex = 6
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(170, 316)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(224, 23)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(497, 316)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(224, 23)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Penumpang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Stasiun Tujuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Stasiun Asal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Harga Tiket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jam Keberangkatan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tanggal Berangkat"
        '
        'FormInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.txtJam)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtTujuan)
        Me.Controls.Add(Me.txtAsal)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtID)
        Me.Name = "FormInput"
        Me.Text = "FormInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAsal As TextBox
    Friend WithEvents txtTujuan As TextBox
    Friend WithEvents txtJam As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
