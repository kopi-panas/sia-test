<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksiSaloBlnLalu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaksiSaloBlnLalu))
        Me.cmdTambah = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.cmdCetak = New System.Windows.Forms.Button()
        Me.cboPeriode = New System.Windows.Forms.ComboBox()
        Me.lblNamaPerkiraan = New System.Windows.Forms.Label()
        Me.txtKredit = New System.Windows.Forms.TextBox()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDebet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTgl = New System.Windows.Forms.DateTimePicker()
        Me.txtKodeRekening = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTambah
        '
        Me.cmdTambah.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Image = CType(resources.GetObject("cmdTambah.Image"), System.Drawing.Image)
        Me.cmdTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTambah.Location = New System.Drawing.Point(60, 178)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 32)
        Me.cmdTambah.TabIndex = 147
        Me.cmdTambah.Text = "&Tambah"
        Me.cmdTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTambah.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(220, 178)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(73, 32)
        Me.cmdEdit.TabIndex = 149
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdHapus
        '
        Me.cmdHapus.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Image = CType(resources.GetObject("cmdHapus.Image"), System.Drawing.Image)
        Me.cmdHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHapus.Location = New System.Drawing.Point(299, 178)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(73, 32)
        Me.cmdHapus.TabIndex = 150
        Me.cmdHapus.Text = "&Hapus"
        Me.cmdHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHapus.UseVisualStyleBackColor = False
        '
        'cmdCetak
        '
        Me.cmdCetak.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCetak.Image = CType(resources.GetObject("cmdCetak.Image"), System.Drawing.Image)
        Me.cmdCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCetak.Location = New System.Drawing.Point(378, 178)
        Me.cmdCetak.Name = "cmdCetak"
        Me.cmdCetak.Size = New System.Drawing.Size(73, 32)
        Me.cmdCetak.TabIndex = 155
        Me.cmdCetak.Text = "&Cetak"
        Me.cmdCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCetak.UseVisualStyleBackColor = False
        '
        'cboPeriode
        '
        Me.cboPeriode.FormattingEnabled = True
        Me.cboPeriode.Location = New System.Drawing.Point(166, 33)
        Me.cboPeriode.MaxLength = 6
        Me.cboPeriode.Name = "cboPeriode"
        Me.cboPeriode.Size = New System.Drawing.Size(94, 21)
        Me.cboPeriode.TabIndex = 13
        '
        'lblNamaPerkiraan
        '
        Me.lblNamaPerkiraan.BackColor = System.Drawing.Color.Khaki
        Me.lblNamaPerkiraan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNamaPerkiraan.Location = New System.Drawing.Point(260, 78)
        Me.lblNamaPerkiraan.Name = "lblNamaPerkiraan"
        Me.lblNamaPerkiraan.Size = New System.Drawing.Size(342, 20)
        Me.lblNamaPerkiraan.TabIndex = 12
        '
        'txtKredit
        '
        Me.txtKredit.BackColor = System.Drawing.Color.White
        Me.txtKredit.Location = New System.Drawing.Point(283, 119)
        Me.txtKredit.MaxLength = 17
        Me.txtKredit.Name = "txtKredit"
        Me.txtKredit.Size = New System.Drawing.Size(111, 20)
        Me.txtKredit.TabIndex = 10
        Me.txtKredit.Text = "0"
        Me.txtKredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdSimpan
        '
        Me.cmdSimpan.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Image = CType(resources.GetObject("cmdSimpan.Image"), System.Drawing.Image)
        Me.cmdSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSimpan.Location = New System.Drawing.Point(141, 178)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(73, 32)
        Me.cmdSimpan.TabIndex = 148
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSimpan.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kredit :"
        '
        'txtDebet
        '
        Me.txtDebet.BackColor = System.Drawing.Color.White
        Me.txtDebet.Location = New System.Drawing.Point(166, 119)
        Me.txtDebet.MaxLength = 17
        Me.txtDebet.Name = "txtDebet"
        Me.txtDebet.Size = New System.Drawing.Size(111, 20)
        Me.txtDebet.TabIndex = 8
        Me.txtDebet.Text = "0"
        Me.txtDebet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Debet :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Periode :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tangal :"
        '
        'txtTgl
        '
        Me.txtTgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtTgl.Location = New System.Drawing.Point(166, 56)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Size = New System.Drawing.Size(111, 20)
        Me.txtTgl.TabIndex = 4
        '
        'txtKodeRekening
        '
        Me.txtKodeRekening.BackColor = System.Drawing.Color.White
        Me.txtKodeRekening.Location = New System.Drawing.Point(166, 78)
        Me.txtKodeRekening.MaxLength = 5
        Me.txtKodeRekening.Name = "txtKodeRekening"
        Me.txtKodeRekening.Size = New System.Drawing.Size(94, 20)
        Me.txtKodeRekening.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Akun :"
        '
        'cmdKeluar
        '
        Me.cmdKeluar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(593, 178)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(73, 32)
        Me.cmdKeluar.TabIndex = 151
        Me.cmdKeluar.Text = "&Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = False
        '
        'ListView
        '
        Me.ListView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.ForeColor = System.Drawing.Color.Black
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.Location = New System.Drawing.Point(60, 216)
        Me.ListView.MultiSelect = False
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(606, 231)
        Me.ListView.TabIndex = 153
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPeriode)
        Me.GroupBox1.Controls.Add(Me.lblNamaPerkiraan)
        Me.GroupBox1.Controls.Add(Me.txtKredit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDebet)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTgl)
        Me.GroupBox1.Controls.Add(Me.txtKodeRekening)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 162)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'frmTransaksiSaloBlnLalu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdCetak)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransaksiSaloBlnLalu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Saldo Awal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdCetak As System.Windows.Forms.Button
    Friend WithEvents cboPeriode As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPerkiraan As System.Windows.Forms.Label
    Friend WithEvents txtKredit As System.Windows.Forms.TextBox
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDebet As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKodeRekening As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
