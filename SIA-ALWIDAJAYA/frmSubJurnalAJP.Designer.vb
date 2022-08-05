<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubJurnalAJP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubJurnalAJP))
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.cboPeriode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdYa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdKeluar
        '
        Me.cmdKeluar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(312, 391)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(73, 29)
        Me.cmdKeluar.TabIndex = 120
        Me.cmdKeluar.Text = "&Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = False
        '
        'cboPeriode
        '
        Me.cboPeriode.FormattingEnabled = True
        Me.cboPeriode.Location = New System.Drawing.Point(195, 43)
        Me.cboPeriode.Name = "cboPeriode"
        Me.cboPeriode.Size = New System.Drawing.Size(90, 21)
        Me.cboPeriode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periode :"
        '
        'cmdYa
        '
        Me.cmdYa.BackColor = System.Drawing.SystemColors.Control
        Me.cmdYa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYa.Image = CType(resources.GetObject("cmdYa.Image"), System.Drawing.Image)
        Me.cmdYa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdYa.Location = New System.Drawing.Point(233, 391)
        Me.cmdYa.Name = "cmdYa"
        Me.cmdYa.Size = New System.Drawing.Size(73, 29)
        Me.cmdYa.TabIndex = 119
        Me.cmdYa.Text = "&Ya"
        Me.cmdYa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdYa.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No.Transaksi :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPeriode)
        Me.GroupBox1.Controls.Add(Me.txtNoTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 122)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.BackColor = System.Drawing.Color.White
        Me.txtNoTransaksi.Location = New System.Drawing.Point(195, 70)
        Me.txtNoTransaksi.MaxLength = 30
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(328, 20)
        Me.txtNoTransaksi.TabIndex = 1
        '
        'ListView
        '
        Me.ListView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.ForeColor = System.Drawing.Color.Black
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.Location = New System.Drawing.Point(35, 139)
        Me.ListView.MultiSelect = False
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(548, 238)
        Me.ListView.TabIndex = 122
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'frmSubJurnalAJP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdYa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubJurnalAJP"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cboPeriode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdYa As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents ListView As System.Windows.Forms.ListView
End Class
