<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAktivaTetap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAktivaTetap))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboAkumulasi = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdHitung = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNilaiBuku = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBeban = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAkumulasi = New System.Windows.Forms.TextBox()
        Me.tglTerhitung = New System.Windows.Forms.DateTimePicker()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.lblBebanPerbulan = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNoSeri = New System.Windows.Forms.TextBox()
        Me.cboPenyusutan = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNilaiResidu = New System.Windows.Forms.TextBox()
        Me.tglPensiun = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHargaPerolehan = New System.Windows.Forms.TextBox()
        Me.tglPerolehan = New System.Windows.Forms.DateTimePicker()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cboKelompok = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboAkumulasi)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 79)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kode Perkiraan:"
        '
        'cboAkumulasi
        '
        Me.cboAkumulasi.FormattingEnabled = True
        Me.cboAkumulasi.Location = New System.Drawing.Point(110, 41)
        Me.cboAkumulasi.Name = "cboAkumulasi"
        Me.cboAkumulasi.Size = New System.Drawing.Size(462, 21)
        Me.cboAkumulasi.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Akumulasi Penyusutan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "bulan"
        '
        'cmdHitung
        '
        Me.cmdHitung.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHitung.Image = CType(resources.GetObject("cmdHitung.Image"), System.Drawing.Image)
        Me.cmdHitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHitung.Location = New System.Drawing.Point(435, 195)
        Me.cmdHitung.Name = "cmdHitung"
        Me.cmdHitung.Size = New System.Drawing.Size(137, 25)
        Me.cmdHitung.TabIndex = 120
        Me.cmdHitung.Text = "&Hitung Penyusutan"
        Me.cmdHitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHitung.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(365, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Nilai Buku :"
        '
        'txtNilaiBuku
        '
        Me.txtNilaiBuku.Location = New System.Drawing.Point(435, 143)
        Me.txtNilaiBuku.MaxLength = 15
        Me.txtNilaiBuku.Name = "txtNilaiBuku"
        Me.txtNilaiBuku.Size = New System.Drawing.Size(137, 20)
        Me.txtNilaiBuku.TabIndex = 28
        Me.txtNilaiBuku.Text = "0"
        Me.txtNilaiBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(315, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Beban Per Tahun Ini :"
        '
        'txtBeban
        '
        Me.txtBeban.Location = New System.Drawing.Point(435, 116)
        Me.txtBeban.MaxLength = 15
        Me.txtBeban.Name = "txtBeban"
        Me.txtBeban.Size = New System.Drawing.Size(137, 20)
        Me.txtBeban.TabIndex = 26
        Me.txtBeban.Text = "0"
        Me.txtBeban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(331, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Akumulasi Beban :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(337, 175)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Baban Perbulan :"
        '
        'txtAkumulasi
        '
        Me.txtAkumulasi.Location = New System.Drawing.Point(435, 89)
        Me.txtAkumulasi.MaxLength = 15
        Me.txtAkumulasi.Name = "txtAkumulasi"
        Me.txtAkumulasi.Size = New System.Drawing.Size(137, 20)
        Me.txtAkumulasi.TabIndex = 24
        Me.txtAkumulasi.Text = "0"
        Me.txtAkumulasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tglTerhitung
        '
        Me.tglTerhitung.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglTerhitung.Location = New System.Drawing.Point(435, 63)
        Me.tglTerhitung.Name = "tglTerhitung"
        Me.tglTerhitung.Size = New System.Drawing.Size(87, 20)
        Me.tglTerhitung.TabIndex = 23
        '
        'cmdSimpan
        '
        Me.cmdSimpan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Image = CType(resources.GetObject("cmdSimpan.Image"), System.Drawing.Image)
        Me.cmdSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSimpan.Location = New System.Drawing.Point(23, 342)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(73, 25)
        Me.cmdSimpan.TabIndex = 127
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSimpan.UseVisualStyleBackColor = False
        '
        'cmdHapus
        '
        Me.cmdHapus.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Image = CType(resources.GetObject("cmdHapus.Image"), System.Drawing.Image)
        Me.cmdHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHapus.Location = New System.Drawing.Point(181, 342)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(73, 25)
        Me.cmdHapus.TabIndex = 129
        Me.cmdHapus.Text = "&Hapus"
        Me.cmdHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHapus.UseVisualStyleBackColor = False
        '
        'lblBebanPerbulan
        '
        Me.lblBebanPerbulan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBebanPerbulan.Location = New System.Drawing.Point(458, 193)
        Me.lblBebanPerbulan.Name = "lblBebanPerbulan"
        Me.lblBebanPerbulan.Size = New System.Drawing.Size(137, 21)
        Me.lblBebanPerbulan.TabIndex = 126
        Me.lblBebanPerbulan.Text = "0"
        Me.lblBebanPerbulan.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(326, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Terhitung Tanggal :"
        '
        'txtNoSeri
        '
        Me.txtNoSeri.Location = New System.Drawing.Point(435, 40)
        Me.txtNoSeri.MaxLength = 15
        Me.txtNoSeri.Name = "txtNoSeri"
        Me.txtNoSeri.Size = New System.Drawing.Size(137, 20)
        Me.txtNoSeri.TabIndex = 21
        '
        'cboPenyusutan
        '
        Me.cboPenyusutan.FormattingEnabled = True
        Me.cboPenyusutan.Items.AddRange(New Object() {"Garis Lurus", "Tanpa Penyusutan"})
        Me.cboPenyusutan.Location = New System.Drawing.Point(110, 194)
        Me.cboPenyusutan.Name = "cboPenyusutan"
        Me.cboPenyusutan.Size = New System.Drawing.Size(158, 21)
        Me.cboPenyusutan.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Penyusutan :"
        '
        'txtNilaiResidu
        '
        Me.txtNilaiResidu.Location = New System.Drawing.Point(110, 168)
        Me.txtNilaiResidu.MaxLength = 15
        Me.txtNilaiResidu.Name = "txtNilaiResidu"
        Me.txtNilaiResidu.Size = New System.Drawing.Size(137, 20)
        Me.txtNilaiResidu.TabIndex = 17
        Me.txtNilaiResidu.Text = "0"
        Me.txtNilaiResidu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tglPensiun
        '
        Me.tglPensiun.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglPensiun.Location = New System.Drawing.Point(110, 142)
        Me.tglPensiun.Name = "tglPensiun"
        Me.tglPensiun.Size = New System.Drawing.Size(87, 20)
        Me.tglPensiun.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nilai Residu :"
        '
        'cmdKeluar
        '
        Me.cmdKeluar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(260, 342)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(73, 25)
        Me.cmdKeluar.TabIndex = 130
        Me.cmdKeluar.Text = "&Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tgl.Pensiun :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Umur Ekonomis :"
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(110, 116)
        Me.txtUmur.MaxLength = 3
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(38, 20)
        Me.txtUmur.TabIndex = 13
        Me.txtUmur.Text = "0"
        Me.txtUmur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Harga Perolehan :"
        '
        'txtHargaPerolehan
        '
        Me.txtHargaPerolehan.Location = New System.Drawing.Point(110, 90)
        Me.txtHargaPerolehan.MaxLength = 15
        Me.txtHargaPerolehan.Name = "txtHargaPerolehan"
        Me.txtHargaPerolehan.Size = New System.Drawing.Size(137, 20)
        Me.txtHargaPerolehan.TabIndex = 11
        Me.txtHargaPerolehan.Text = "0"
        Me.txtHargaPerolehan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tglPerolehan
        '
        Me.tglPerolehan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tglPerolehan.Location = New System.Drawing.Point(110, 67)
        Me.tglPerolehan.Name = "tglPerolehan"
        Me.tglPerolehan.Size = New System.Drawing.Size(87, 20)
        Me.tglPerolehan.TabIndex = 10
        '
        'lblNama
        '
        Me.lblNama.BackColor = System.Drawing.Color.White
        Me.lblNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNama.Location = New System.Drawing.Point(110, 16)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(462, 21)
        Me.lblNama.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tgl.Perolehan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No.Seri :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kelompok :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama :"
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(102, 342)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(73, 25)
        Me.cmdEdit.TabIndex = 128
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cboKelompok
        '
        Me.cboKelompok.FormattingEnabled = True
        Me.cboKelompok.Items.AddRange(New Object() {"A. Tanah", "B. Bangunan", "C. Kendaraan", "D. Peralatan", "E. Mebel"})
        Me.cboKelompok.Location = New System.Drawing.Point(110, 40)
        Me.cboKelompok.Name = "cboKelompok"
        Me.cboKelompok.Size = New System.Drawing.Size(158, 21)
        Me.cboKelompok.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdHitung)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtNilaiBuku)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtBeban)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtAkumulasi)
        Me.GroupBox1.Controls.Add(Me.tglTerhitung)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNoSeri)
        Me.GroupBox1.Controls.Add(Me.cboPenyusutan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNilaiResidu)
        Me.GroupBox1.Controls.Add(Me.tglPensiun)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtUmur)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHargaPerolehan)
        Me.GroupBox1.Controls.Add(Me.tglPerolehan)
        Me.GroupBox1.Controls.Add(Me.cboKelompok)
        Me.GroupBox1.Controls.Add(Me.lblNama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 229)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        '
        'frmAktivaTetap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.lblBebanPerbulan)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAktivaTetap"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aktiva Tetap"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAkumulasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdHitung As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNilaiBuku As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBeban As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAkumulasi As System.Windows.Forms.TextBox
    Friend WithEvents tglTerhitung As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents lblBebanPerbulan As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNoSeri As System.Windows.Forms.TextBox
    Friend WithEvents cboPenyusutan As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNilaiResidu As System.Windows.Forms.TextBox
    Friend WithEvents tglPensiun As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHargaPerolehan As System.Windows.Forms.TextBox
    Friend WithEvents tglPerolehan As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cboKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
