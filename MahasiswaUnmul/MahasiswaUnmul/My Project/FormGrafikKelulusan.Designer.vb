<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGrafikKelulusan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLihatInfo = New System.Windows.Forms.Button()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.btnLihatInfo)
        Me.Panel3.Controls.Add(Me.btnGrafik)
        Me.Panel3.Controls.Add(Me.BtnInput)
        Me.Panel3.Location = New System.Drawing.Point(11, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(154, 171)
        Me.Panel3.TabIndex = 5
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
        'btnLihatInfo
        '
        Me.btnLihatInfo.Location = New System.Drawing.Point(3, 93)
        Me.btnLihatInfo.Name = "btnLihatInfo"
        Me.btnLihatInfo.Size = New System.Drawing.Size(148, 23)
        Me.btnLihatInfo.TabIndex = 8
        Me.btnLihatInfo.Text = "Informasi Mahasiswa"
        Me.btnLihatInfo.UseVisualStyleBackColor = True
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
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(3, 12)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(148, 23)
        Me.BtnInput.TabIndex = 6
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
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
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(232, 58)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(538, 300)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Red
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.Location = New System.Drawing.Point(49, 373)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 35
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormGrafikKelulusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormGrafikKelulusan"
        Me.Text = "FormGrafikKelulusan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLihatInfo As Button
    Friend WithEvents btnGrafik As Button
    Friend WithEvents BtnInput As Button
    Friend WithEvents btnKeluar As Button
End Class
