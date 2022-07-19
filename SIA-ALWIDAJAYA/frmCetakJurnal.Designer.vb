<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetakJurnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCetakJurnal))
        Me.cboPeriodeNS = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdCetakNS = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPeriodeBB = New System.Windows.Forms.ComboBox()
        Me.jurnalumum = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdCetakJU = New System.Windows.Forms.Button()
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboPeriodeJU = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdCetakBB = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bukubesar = New System.Windows.Forms.Panel()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.neracasaldo = New System.Windows.Forms.Panel()
        Me.cmdNS = New System.Windows.Forms.Button()
        Me.cmdBB = New System.Windows.Forms.Button()
        Me.cmdJU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.jurnalumum.SuspendLayout()
        Me.Group.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.bukubesar.SuspendLayout()
        Me.neracasaldo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboPeriodeNS
        '
        Me.cboPeriodeNS.BackColor = System.Drawing.SystemColors.Window
        Me.cboPeriodeNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodeNS.FormattingEnabled = True
        Me.cboPeriodeNS.Location = New System.Drawing.Point(82, 19)
        Me.cboPeriodeNS.Name = "cboPeriodeNS"
        Me.cboPeriodeNS.Size = New System.Drawing.Size(160, 21)
        Me.cboPeriodeNS.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Cetak Neraca Saldo"
        '
        'cmdCetakNS
        '
        Me.cmdCetakNS.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCetakNS.Image = CType(resources.GetObject("cmdCetakNS.Image"), System.Drawing.Image)
        Me.cmdCetakNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCetakNS.Location = New System.Drawing.Point(105, 141)
        Me.cmdCetakNS.Name = "cmdCetakNS"
        Me.cmdCetakNS.Size = New System.Drawing.Size(74, 32)
        Me.cmdCetakNS.TabIndex = 123
        Me.cmdCetakNS.Text = "&Cetak"
        Me.cmdCetakNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCetakNS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboPeriodeNS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 54)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Periode :"
        '
        'cboPeriodeBB
        '
        Me.cboPeriodeBB.BackColor = System.Drawing.SystemColors.Window
        Me.cboPeriodeBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodeBB.FormattingEnabled = True
        Me.cboPeriodeBB.Location = New System.Drawing.Point(82, 19)
        Me.cboPeriodeBB.Name = "cboPeriodeBB"
        Me.cboPeriodeBB.Size = New System.Drawing.Size(160, 21)
        Me.cboPeriodeBB.TabIndex = 61
        '
        'jurnalumum
        '
        Me.jurnalumum.Controls.Add(Me.Label3)
        Me.jurnalumum.Controls.Add(Me.cmdCetakJU)
        Me.jurnalumum.Controls.Add(Me.Group)
        Me.jurnalumum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jurnalumum.Location = New System.Drawing.Point(142, 0)
        Me.jurnalumum.Name = "jurnalumum"
        Me.jurnalumum.Size = New System.Drawing.Size(299, 196)
        Me.jurnalumum.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Cetak Jurnal Umum"
        '
        'cmdCetakJU
        '
        Me.cmdCetakJU.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCetakJU.Image = CType(resources.GetObject("cmdCetakJU.Image"), System.Drawing.Image)
        Me.cmdCetakJU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCetakJU.Location = New System.Drawing.Point(105, 142)
        Me.cmdCetakJU.Name = "cmdCetakJU"
        Me.cmdCetakJU.Size = New System.Drawing.Size(74, 32)
        Me.cmdCetakJU.TabIndex = 121
        Me.cmdCetakJU.Text = "&Cetak"
        Me.cmdCetakJU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCetakJU.UseVisualStyleBackColor = True
        '
        'Group
        '
        Me.Group.Controls.Add(Me.Label15)
        Me.Group.Controls.Add(Me.cboPeriodeJU)
        Me.Group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group.Location = New System.Drawing.Point(13, 65)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(263, 54)
        Me.Group.TabIndex = 120
        Me.Group.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Periode :"
        '
        'cboPeriodeJU
        '
        Me.cboPeriodeJU.BackColor = System.Drawing.SystemColors.Window
        Me.cboPeriodeJU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodeJU.FormattingEnabled = True
        Me.cboPeriodeJU.Location = New System.Drawing.Point(82, 19)
        Me.cboPeriodeJU.Name = "cboPeriodeJU"
        Me.cboPeriodeJU.Size = New System.Drawing.Size(160, 21)
        Me.cboPeriodeJU.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Periode :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Cetak Buku Besar"
        '
        'cmdCetakBB
        '
        Me.cmdCetakBB.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCetakBB.Image = CType(resources.GetObject("cmdCetakBB.Image"), System.Drawing.Image)
        Me.cmdCetakBB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCetakBB.Location = New System.Drawing.Point(111, 147)
        Me.cmdCetakBB.Name = "cmdCetakBB"
        Me.cmdCetakBB.Size = New System.Drawing.Size(74, 32)
        Me.cmdCetakBB.TabIndex = 123
        Me.cmdCetakBB.Text = "&Cetak"
        Me.cmdCetakBB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCetakBB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPeriodeBB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 54)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'bukubesar
        '
        Me.bukubesar.Controls.Add(Me.Label4)
        Me.bukubesar.Controls.Add(Me.cmdCetakBB)
        Me.bukubesar.Controls.Add(Me.GroupBox1)
        Me.bukubesar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bukubesar.Location = New System.Drawing.Point(142, 0)
        Me.bukubesar.Name = "bukubesar"
        Me.bukubesar.Size = New System.Drawing.Size(299, 196)
        Me.bukubesar.TabIndex = 128
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(29, 161)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(74, 32)
        Me.cmdKeluar.TabIndex = 121
        Me.cmdKeluar.Text = "&Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'neracasaldo
        '
        Me.neracasaldo.Controls.Add(Me.Label5)
        Me.neracasaldo.Controls.Add(Me.cmdCetakNS)
        Me.neracasaldo.Controls.Add(Me.GroupBox2)
        Me.neracasaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.neracasaldo.Location = New System.Drawing.Point(142, 0)
        Me.neracasaldo.Name = "neracasaldo"
        Me.neracasaldo.Size = New System.Drawing.Size(299, 196)
        Me.neracasaldo.TabIndex = 129
        '
        'cmdNS
        '
        Me.cmdNS.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNS.Image = CType(resources.GetObject("cmdNS.Image"), System.Drawing.Image)
        Me.cmdNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNS.Location = New System.Drawing.Point(12, 103)
        Me.cmdNS.Name = "cmdNS"
        Me.cmdNS.Size = New System.Drawing.Size(114, 32)
        Me.cmdNS.TabIndex = 122
        Me.cmdNS.Text = "Neraca Saldo"
        Me.cmdNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNS.UseVisualStyleBackColor = True
        '
        'cmdBB
        '
        Me.cmdBB.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBB.Image = CType(resources.GetObject("cmdBB.Image"), System.Drawing.Image)
        Me.cmdBB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBB.Location = New System.Drawing.Point(12, 65)
        Me.cmdBB.Name = "cmdBB"
        Me.cmdBB.Size = New System.Drawing.Size(114, 32)
        Me.cmdBB.TabIndex = 123
        Me.cmdBB.Text = "Buku Besar"
        Me.cmdBB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBB.UseVisualStyleBackColor = True
        '
        'cmdJU
        '
        Me.cmdJU.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdJU.Image = CType(resources.GetObject("cmdJU.Image"), System.Drawing.Image)
        Me.cmdJU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdJU.Location = New System.Drawing.Point(12, 27)
        Me.cmdJU.Name = "cmdJU"
        Me.cmdJU.Size = New System.Drawing.Size(114, 32)
        Me.cmdJU.TabIndex = 124
        Me.cmdJU.Text = "Jurnal Umum"
        Me.cmdJU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdJU.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdNS)
        Me.Panel1.Controls.Add(Me.cmdBB)
        Me.Panel1.Controls.Add(Me.cmdJU)
        Me.Panel1.Controls.Add(Me.cmdKeluar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(142, 196)
        Me.Panel1.TabIndex = 126
        '
        'frmCetakJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.jurnalumum)
        Me.Controls.Add(Me.bukubesar)
        Me.Controls.Add(Me.neracasaldo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCetakJurnal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Jurnal Umum"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.jurnalumum.ResumeLayout(False)
        Me.jurnalumum.PerformLayout()
        Me.Group.ResumeLayout(False)
        Me.Group.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.bukubesar.ResumeLayout(False)
        Me.bukubesar.PerformLayout()
        Me.neracasaldo.ResumeLayout(False)
        Me.neracasaldo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboPeriodeNS As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdCetakNS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodeBB As System.Windows.Forms.ComboBox
    Friend WithEvents jurnalumum As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdCetakJU As System.Windows.Forms.Button
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodeJU As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdCetakBB As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bukubesar As System.Windows.Forms.Panel
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents neracasaldo As System.Windows.Forms.Panel
    Friend WithEvents cmdNS As System.Windows.Forms.Button
    Friend WithEvents cmdBB As System.Windows.Forms.Button
    Friend WithEvents cmdJU As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
