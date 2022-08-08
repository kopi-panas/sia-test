Imports System.Data.OleDb
Public Class frmTransaksiSaloBlnLalu

    Dim objSaldoBlnLalu As New clsSaldoBlnLalu

    Public mDK As String

    Private Sub PosisiList()
        With ListView.Columns
            .Add("Periode", 0)
            .Add("Tanggal", 0)
            .Add("Kode", 55)
            .Add("Nama Akun", 250)
            .Add("D/K", 40)
            .Add("Debet", 120, HorizontalAlignment.Right)
            .Add("Kredit", 120, HorizontalAlignment.Right)
            .Add("Status", 0)
        End With
    End Sub

    Public Sub IsiList()
        Try
            Query = "SELECT tmpSaldoBlnLalu.Periode, tmpSaldoBlnLalu.TglTransaksi, tmpSaldoBlnLalu.NoPerkiraan, tblMasterPerkiraan.NamaPerkiraan, tmpSaldoBlnLalu.DK, tmpSaldoBlnLalu.Debet, tmpSaldoBlnLalu.Kredit, tmpSaldoBlnLalu.Status FROM (tmpSaldoBlnLalu LEFT JOIN tblMasterPeriode ON tmpSaldoBlnLalu.Periode = tblMasterPeriode.Periode) LEFT JOIN tblMasterPerkiraan ON tmpSaldoBlnLalu.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE (((tmpSaldoBlnLalu.Periode)='" & cboPeriode.Text & "')) ORDER BY tmpSaldoBlnLalu.Periode, tmpSaldoBlnLalu.NoPerkiraan"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(5), "###,###"))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(6), "###,###"))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.Transparent
                    Else
                        .Items(a).BackColor = Color.White
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    'Sub rutin ini digunakan untuk cek setup saldo awal.
    Private Sub CekSetUp()
        Dim Pesan As String

        Try
            Query = "SELECT *  FROM tblStatusSetupSaldoAwal"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                txtTgl.Enabled = True
                txtDebet.Enabled = True
                txtKredit.Enabled = True
                txtKodeRekening.Enabled = True
                cmdTambah.Enabled = True
                cmdSimpan.Enabled = True
                cmdEdit.Enabled = True
                cmdHapus.Enabled = True
            Else
                Pesan = MsgBox("Maaf anda tidak boleh memasukkan saldo awal lagi" & vbCrLf _
                    & "karena sudah melakukan proses posting, menu ini digunakan hanya untuk pertama kali menggunakan aplikasi ini. " & vbCrLf _
                    & "Saldo awal periode-periode berikunya dilakukan secara otomastis oleh sistem.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")

                txtTgl.Enabled = False
                txtDebet.Enabled = False
                txtKredit.Enabled = False
                txtKodeRekening.Enabled = False
                cmdTambah.Enabled = False
                cmdSimpan.Enabled = False
                cmdEdit.Enabled = False
                cmdHapus.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AmbilData()
        Try
            With ListView.SelectedItems
                cboPeriode.Text = .Item(0).SubItems(0).Text
                txtTgl.Text = .Item(0).SubItems(1).Text
                txtKodeRekening.Text = .Item(0).SubItems(2).Text
                lblNamaPerkiraan.Text = .Item(0).SubItems(3).Text
                mDK = .Item(0).SubItems(4).Text
                txtDebet.Text = .Item(0).SubItems(5).Text
                txtKredit.Text = .Item(0).SubItems(6).Text
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Periode()
        Try
            Query = "SELECT tblMasterPeriode.Periode FROM tblMasterPeriode ORDER BY tblMasterPeriode.Periode Desc"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            cboPeriode.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With cboPeriode
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CariNoPerkiraan()
        Try
            Query = "SELECT tblMasterPerkiraan.NoPerkiraan, tblMasterPerkiraan.NamaPerkiraan FROM(tblMasterPerkiraan) WHERE (((tblMasterPerkiraan.NoPerkiraan)='" & txtKodeRekening.Text & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count - 1 Then
                MsgBox("No.Perkiraan ini tidak ada", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Cari no perkiraan")
                txtKodeRekening.Focus()
                txtKodeRekening.Text = ""
                lblNamaPerkiraan.Text = ""
            Else
                txtKodeRekening.Text = dsData.Tables(0).Rows(0).Item(0)
                lblNamaPerkiraan.Text = dsData.Tables(0).Rows(0).Item(1)
                txtDebet.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub BersihkanIsian()
        cboPeriode.Enabled = True
        txtTgl.Enabled = True
        txtKodeRekening.Enabled = True
        txtKodeRekening.Text = ""
        lblNamaPerkiraan.Text = ""
        mDK = ""
        txtDebet.Text = "0"
        txtKredit.Text = "0"
    End Sub

    Private Sub txtDebet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebet.KeyPress
        If e.KeyChar = Chr(13) Then
            txtKredit.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        With objSaldoBlnLalu
            .Keluar()
        End With
    End Sub

    Private Sub txtKodeRekening_DoubleClick(sender As Object, e As EventArgs) Handles txtKodeRekening.DoubleClick
        frmSubNoPerkiraan_SaloAwal.ShowDialog()
    End Sub

    Private Sub txtKodeRekening_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeRekening.KeyPress
        If e.KeyChar = Chr(13) Then
            If cboPeriode.Text = "" Then
                MsgBox("Periode tidak boleh kosong, silahkan isi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Isi keterangan")
                cboPeriode.Focus()
            Else
                If txtTgl.Text = "" Then
                    txtTgl.Focus()
                Else
                    CariNoPerkiraan()
                End If
            End If
        End If
    End Sub

    Private Sub txtKredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKredit.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdSimpan.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmTransaksiSaloBlnLalu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cboPeriode.Focus()
    End Sub

    Private Sub frmTransaksiSaloBlnLalu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiKeAccess()
            PosisiList()
            IsiList()
            CekSetUp()
            Periode()
        Catch ex As Exception
            MsgBox("Koneksi ke database gagal")
        End Try
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        Try
            If Val(txtDebet.Text) > Val(txtKredit.Text) Then
                mDK = "D"
            Else
                mDK = "K"
            End If

            If txtDebet.Text = "" Then
                txtDebet.Text = 0
            Else
                txtDebet.Text = txtDebet.Text
            End If

            If txtKredit.Text = "" Then
                txtKredit.Text = 0
            Else
                txtKredit.Text = txtKredit.Text
            End If

            With objSaldoBlnLalu
                .SimpanData()
            End With
            IsiList()
            BersihkanIsian()
            txtKodeRekening.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboPeriode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPeriode.KeyPress
        If e.KeyChar = Chr(13) Then
            If cboPeriode.Text = "" Then
                MsgBox("Periode masih kosong, silahkan diisi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                cboPeriode.Focus()
            Else
                txtTgl.Focus()
            End If
        End If
    End Sub

    Private Sub cboPeriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriode.SelectedIndexChanged
        IsiList()
    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        With objSaldoBlnLalu
            .TambahData()
        End With
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        Try
            If Len(txtKodeRekening.Text) = 0 Then
                MsgBox("Pilih data yang dihapus", MsgBoxStyle.Information, "Perhatian")
                txtKodeRekening.Focus()
                Exit Sub
            Else
                Dim A As String

                A = MsgBox("Benar akan dihapus...", MsgBoxStyle.OkCancel, "Informasi")
                Select Case A
                    Case vbCancel
                        txtKodeRekening.Focus()
                        Exit Sub
                    Case vbOK
                        With objSaldoBlnLalu
                            .HapusData()
                        End With
                        IsiList()
                        BersihkanIsian()
                        txtKodeRekening.Focus()
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
        End Try
    End Sub

    Private Sub ListView_DoubleClick(sender As Object, e As EventArgs) Handles ListView.DoubleClick
        AmbilData()
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged
        AmbilData()
        cboPeriode.Enabled = False
        txtTgl.Enabled = False
        txtKodeRekening.Enabled = False
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim A As String

        A = MsgBox("Benar akan di-Edit", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Informasi")
        Select Case A
            Case vbCancel
                BersihkanIsian()
                txtKodeRekening.Focus()
                Exit Sub
            Case vbOK
                Try
                    With objSaldoBlnLalu
                        .EditData()
                    End With
                    IsiList()
                Catch ex As Exception
                End Try
        End Select
    End Sub

    Private Sub cmdCetak_Click(sender As Object, e As EventArgs) Handles cmdCetak.Click
        If Len(cboPeriode.Text) = 0 Then
            MsgBox("Pilih periode yang akan dicetak", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriode.Focus()
        Else
            Try
                frmRptMutasiSaldo.CrystalReportViewer1.SelectionFormula = "{tmpSaldoBlnLalu.Periode} = '" & cboPeriode.Text & "'"
                frmRptMutasiSaldo.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptMutasiSaldo.CrystalReportViewer1.RefreshReport()
                frmRptMutasiSaldo.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class