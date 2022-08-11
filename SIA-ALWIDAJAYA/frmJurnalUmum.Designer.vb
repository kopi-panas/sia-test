<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnalUmum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJurnalUmum))
        Me.txtKredit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdTambah = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNoPerkiraan = New System.Windows.Forms.TextBox()
        Me.txtTgl = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNoTransaksi = New System.Windows.Forms.Label()
        Me.cmdTransaksi = New System.Windows.Forms.Button()
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.txtDebet = New System.Windows.Forms.TextBox()
        Me.lblNamaPerkiraan = New System.Windows.Forms.Label()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.lblKredit = New System.Windows.Forms.Label()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.lblDebet = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKredit
        '
        Me.txtKredit.BackColor = System.Drawing.Color.White
        Me.txtKredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKredit.Location = New System.Drawing.Point(618, 183)
        Me.txtKredit.MaxLength = 17
        Me.txtKredit.Name = "txtKredit"
        Me.txtKredit.Size = New System.Drawing.Size(125, 20)
        Me.txtKredit.TabIndex = 166
        Me.txtKredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Keterangan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No.Transaksi :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Total :"
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(337, 132)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(85, 34)
        Me.cmdEdit.TabIndex = 158
        Me.cmdEdit.Text = "&Update"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdTambah
        '
        Me.cmdTambah.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Image = CType(resources.GetObject("cmdTambah.Image"), System.Drawing.Image)
        Me.cmdTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTambah.Location = New System.Drawing.Point(153, 132)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(87, 34)
        Me.cmdTambah.TabIndex = 156
        Me.cmdTambah.Text = "&Tambah"
        Me.cmdTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTambah.UseVisualStyleBackColor = False
        '
        'cmdHapus
        '
        Me.cmdHapus.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Image = CType(resources.GetObject("cmdHapus.Image"), System.Drawing.Image)
        Me.cmdHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHapus.Location = New System.Drawing.Point(428, 132)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(85, 34)
        Me.cmdHapus.TabIndex = 159
        Me.cmdHapus.Text = "&Hapus"
        Me.cmdHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHapus.UseVisualStyleBackColor = False
        '
        'ListView
        '
        Me.ListView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.ForeColor = System.Drawing.Color.Black
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.Location = New System.Drawing.Point(60, 206)
        Me.ListView.MultiSelect = False
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(684, 210)
        Me.ListView.TabIndex = 162
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Location = New System.Drawing.Point(153, 78)
        Me.txtKeterangan.MaxLength = 60
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(543, 20)
        Me.txtKeterangan.TabIndex = 1
        '
        'txtNoPerkiraan
        '
        Me.txtNoPerkiraan.BackColor = System.Drawing.Color.White
        Me.txtNoPerkiraan.Location = New System.Drawing.Point(61, 183)
        Me.txtNoPerkiraan.MaxLength = 5
        Me.txtNoPerkiraan.Name = "txtNoPerkiraan"
        Me.txtNoPerkiraan.Size = New System.Drawing.Size(70, 20)
        Me.txtNoPerkiraan.TabIndex = 163
        '
        'txtTgl
        '
        Me.txtTgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtTgl.Location = New System.Drawing.Point(153, 52)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Size = New System.Drawing.Size(91, 20)
        Me.txtTgl.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNoTransaksi)
        Me.GroupBox1.Controls.Add(Me.cmdTransaksi)
        Me.GroupBox1.Controls.Add(Me.lblPeriode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTgl)
        Me.GroupBox1.Controls.Add(Me.txtKeterangan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 126)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        '
        'lblNoTransaksi
        '
        Me.lblNoTransaksi.BackColor = System.Drawing.Color.LightBlue
        Me.lblNoTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTransaksi.Location = New System.Drawing.Point(154, 25)
        Me.lblNoTransaksi.Name = "lblNoTransaksi"
        Me.lblNoTransaksi.Size = New System.Drawing.Size(98, 22)
        Me.lblNoTransaksi.TabIndex = 17
        Me.lblNoTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdTransaksi
        '
        Me.cmdTransaksi.Image = CType(resources.GetObject("cmdTransaksi.Image"), System.Drawing.Image)
        Me.cmdTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTransaksi.Location = New System.Drawing.Point(253, 21)
        Me.cmdTransaksi.Name = "cmdTransaksi"
        Me.cmdTransaksi.Size = New System.Drawing.Size(29, 28)
        Me.cmdTransaksi.TabIndex = 16
        Me.cmdTransaksi.UseVisualStyleBackColor = True
        '
        'lblPeriode
        '
        Me.lblPeriode.BackColor = System.Drawing.Color.PeachPuff
        Me.lblPeriode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPeriode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriode.Location = New System.Drawing.Point(677, 33)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(66, 20)
        Me.lblPeriode.TabIndex = 7
        Me.lblPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(613, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Periode :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tgl.Transaksi :"
        '
        'cmdSimpan
        '
        Me.cmdSimpan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Image = CType(resources.GetObject("cmdSimpan.Image"), System.Drawing.Image)
        Me.cmdSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSimpan.Location = New System.Drawing.Point(246, 132)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(85, 34)
        Me.cmdSimpan.TabIndex = 157
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSimpan.UseVisualStyleBackColor = False
        '
        'txtDebet
        '
        Me.txtDebet.BackColor = System.Drawing.Color.White
        Me.txtDebet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebet.Location = New System.Drawing.Point(492, 183)
        Me.txtDebet.MaxLength = 17
        Me.txtDebet.Name = "txtDebet"
        Me.txtDebet.Size = New System.Drawing.Size(125, 20)
        Me.txtDebet.TabIndex = 165
        Me.txtDebet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNamaPerkiraan
        '
        Me.lblNamaPerkiraan.BackColor = System.Drawing.Color.LightGray
        Me.lblNamaPerkiraan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNamaPerkiraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPerkiraan.Location = New System.Drawing.Point(131, 183)
        Me.lblNamaPerkiraan.Name = "lblNamaPerkiraan"
        Me.lblNamaPerkiraan.Size = New System.Drawing.Size(360, 20)
        Me.lblNamaPerkiraan.TabIndex = 164
        '
        'cmdKeluar
        '
        Me.cmdKeluar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(659, 448)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(85, 34)
        Me.cmdKeluar.TabIndex = 160
        Me.cmdKeluar.Text = "&Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = False
        '
        'lblKredit
        '
        Me.lblKredit.BackColor = System.Drawing.Color.SkyBlue
        Me.lblKredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKredit.Location = New System.Drawing.Point(619, 417)
        Me.lblKredit.Name = "lblKredit"
        Me.lblKredit.Size = New System.Drawing.Size(125, 20)
        Me.lblKredit.TabIndex = 167
        Me.lblKredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdPreview
        '
        Me.cmdPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.Image = CType(resources.GetObject("cmdPreview.Image"), System.Drawing.Image)
        Me.cmdPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPreview.Location = New System.Drawing.Point(568, 448)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(85, 34)
        Me.cmdPreview.TabIndex = 169
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPreview.UseVisualStyleBackColor = False
        '
        'lblDebet
        '
        Me.lblDebet.BackColor = System.Drawing.Color.SkyBlue
        Me.lblDebet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDebet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebet.Location = New System.Drawing.Point(494, 417)
        Me.lblDebet.Name = "lblDebet"
        Me.lblDebet.Size = New System.Drawing.Size(125, 20)
        Me.lblDebet.TabIndex = 168
        Me.lblDebet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmJurnalUmum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKredit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.txtNoPerkiraan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.txtDebet)
        Me.Controls.Add(Me.lblNamaPerkiraan)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.lblKredit)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.lblDebet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJurnalUmum"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jurnal Umum"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKredit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPerkiraan As System.Windows.Forms.TextBox
    Friend WithEvents txtTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPeriode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents txtDebet As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaPerkiraan As System.Windows.Forms.Label
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents lblKredit As System.Windows.Forms.Label
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents lblDebet As System.Windows.Forms.Label
    Friend WithEvents cmdTransaksi As System.Windows.Forms.Button
    Friend WithEvents lblNoTransaksi As System.Windows.Forms.Label
End Class
