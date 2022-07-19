<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.cmdMasuk = New System.Windows.Forms.Button()
        Me.txtSandi = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 38)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SISTEM INFORMASI AKUNTANSI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UD AL-WIDA JAYA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(236, 212)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(79, 30)
        Me.cmdKeluar.TabIndex = 18
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'cmdMasuk
        '
        Me.cmdMasuk.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMasuk.Image = CType(resources.GetObject("cmdMasuk.Image"), System.Drawing.Image)
        Me.cmdMasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMasuk.Location = New System.Drawing.Point(151, 212)
        Me.cmdMasuk.Name = "cmdMasuk"
        Me.cmdMasuk.Size = New System.Drawing.Size(79, 30)
        Me.cmdMasuk.TabIndex = 17
        Me.cmdMasuk.Text = "Masuk"
        Me.cmdMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdMasuk.UseVisualStyleBackColor = True
        '
        'txtSandi
        '
        Me.txtSandi.Location = New System.Drawing.Point(213, 160)
        Me.txtSandi.Name = "txtSandi"
        Me.txtSandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSandi.Size = New System.Drawing.Size(122, 20)
        Me.txtSandi.TabIndex = 16
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(213, 127)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(122, 20)
        Me.txtkode.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Kata Sandi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama Pengguna"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 293)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdMasuk)
        Me.Controls.Add(Me.txtSandi)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cmdMasuk As System.Windows.Forms.Button
    Friend WithEvents txtSandi As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
