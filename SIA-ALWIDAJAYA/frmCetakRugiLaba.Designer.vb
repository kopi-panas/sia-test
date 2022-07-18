<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetakRugiLaba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCetakRugiLaba))
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboPeriode = New System.Windows.Forms.ComboBox()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.cmdCetak = New System.Windows.Forms.Button()
        Me.Group.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group
        '
        Me.Group.Controls.Add(Me.Label15)
        Me.Group.Controls.Add(Me.cboPeriode)
        Me.Group.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group.Location = New System.Drawing.Point(45, 25)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(263, 66)
        Me.Group.TabIndex = 124
        Me.Group.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Periode :"
        '
        'cboPeriode
        '
        Me.cboPeriode.BackColor = System.Drawing.SystemColors.Window
        Me.cboPeriode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriode.FormattingEnabled = True
        Me.cboPeriode.Location = New System.Drawing.Point(80, 28)
        Me.cboPeriode.Name = "cboPeriode"
        Me.cboPeriode.Size = New System.Drawing.Size(161, 21)
        Me.cboPeriode.TabIndex = 61
        '
        'cmdKeluar
        '
        Me.cmdKeluar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(182, 108)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(73, 29)
        Me.cmdKeluar.TabIndex = 126
        Me.cmdKeluar.Text = "&Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = False
        '
        'cmdCetak
        '
        Me.cmdCetak.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCetak.Image = CType(resources.GetObject("cmdCetak.Image"), System.Drawing.Image)
        Me.cmdCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCetak.Location = New System.Drawing.Point(103, 108)
        Me.cmdCetak.Name = "cmdCetak"
        Me.cmdCetak.Size = New System.Drawing.Size(73, 29)
        Me.cmdCetak.TabIndex = 125
        Me.cmdCetak.Text = "&Cetak"
        Me.cmdCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCetak.UseVisualStyleBackColor = False
        '
        'frmCetakRugiLaba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.Group)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdCetak)
        Me.Name = "frmCetakRugiLaba"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Rugi Laba"
        Me.Group.ResumeLayout(False)
        Me.Group.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboPeriode As System.Windows.Forms.ComboBox
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cmdCetak As System.Windows.Forms.Button
End Class
