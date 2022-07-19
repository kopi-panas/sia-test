Imports System.Data.OleDb
Public Class FormMenuUtama

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnPengguna_Click(sender As Object, e As EventArgs) Handles btnPengguna.Click
        frmMasterUser.Show()
    End Sub

    Private Sub btnCoA_Click(sender As Object, e As EventArgs) Handles btnCoA.Click
        frmPerkiraan.Show()
    End Sub

    Private Sub btnPeriode_Click(sender As Object, e As EventArgs) Handles btnPeriode.Click
        frmMasterPeriode.Show()
    End Sub

    Private Sub btnJurnalUmum_Click(sender As Object, e As EventArgs) Handles btnJurnalUmum.Click
        frmJurnalUmum.Show()
    End Sub

    Private Sub btnAJP_Click(sender As Object, e As EventArgs) Handles btnAJP.Click
        frmJurnalPenyesuaian.Show()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        frmPosting.Show()
    End Sub

    Private Sub SetUpSaldoAwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetUpSaldoAwalToolStripMenuItem.Click
        frmTransaksiSaloBlnLalu.Show()
    End Sub

    Private Sub btnLapNL_Click(sender As Object, e As EventArgs) Handles btnLapNL.Click
        frmCetakNeracaLajur.Show()
    End Sub

    Private Sub btnLapRL_Click(sender As Object, e As EventArgs) Handles btnLapRL.Click
        frmCetakRugiLaba.Show()
    End Sub

    Private Sub btnLapPM_Click(sender As Object, e As EventArgs) Handles btnLapPM.Click
        frmCetakPerubahanModal.Show()
    End Sub

    Private Sub btnLapNeraca_Click(sender As Object, e As EventArgs) Handles btnLapNeraca.Click
        frmCetakNeraca.Show()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Dim A As String

        A = MsgBox("Fasilitas ini digunakan untuk menghapus semua data latihan, yakin menghapus", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Informasi")
        Select Case A
            Case vbCancel
                Exit Sub
            Case vbOK
                HJurnal()
                DJurnal()
                HJurnalAJP()
                DJurnalAJP()
                HapusSaldoBulanlalu()
                HapusBukuBesar()
                HapustBukuBesarAJP()
                HapusNeracaSaldo()
                HapusNeracaSaldoAJP()
                HapusNeracaLajur()
                HapusRugiLaba()
                HapusNilaiNerca()
                HapusModal()
                HapusLabaTakDibagi()
                HapusSaldoAwal()
                HapusKeteranganSaldoAwal()
                HapusBulanLalu()
                HapusPeriode()
        End Select
    End Sub

    Public Sub HJurnal()
        Try
            Query = "DELETE FROM hJurnal"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DJurnal()
        Try
            Query = "DELETE FROM DJurnal"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HJurnalAJP()
        Try
            Query = "DELETE FROM hJurnalAJP"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DJurnalAJP()
        Try
            Query = "DELETE FROM DJurnalAJP"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusSaldoBulanlalu()
        Try
            Query = "DELETE FROM BukuBesar"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusBukuBesar()
        Try
            Query = "DELETE FROM  BukuBesar"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapustBukuBesarAJP()
        Try
            Query = "DELETE FROM  BukuBesarAJP"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusNeracaSaldo()
        Try
            Query = "DELETE FROM  NeracaSaldo"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusNeracaSaldoAJP()
        Try
            Query = "DELETE FROM  tblAJP"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusNeracaLajur()
        Try
            Query = "DELETE FROM  NeracaLajur"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusRugiLaba()
        Try
            Query = "DELETE FROM tblRugiLaba"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusNilaiNerca()
        Try
            Query = "DELETE FROM  tblNeraca"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusModal()
        Try
            Query = "DELETE FROM  tblPerubahanModal"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusLabaTakDibagi()
        Try
            Query = "DELETE FROM tblNeraca"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusAliranKas()
        Try
            Query = "DELETE FROM AliranKas"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusSaldoAwal()
        Try
            Query = "DELETE FROM tmpSaldoBlnLalu"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusKeteranganSaldoAwal()
        Try
            Query = "DELETE FROM tblStatusSetupSaldoAwal"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusBulanLalu()
        Try
            Query = "DELETE FROM tmpSaldoBlnLalu"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub HapusPeriode()
        Try
            Query = "DELETE FROM tblMasterPeriode"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLapJU_Click(sender As Object, e As EventArgs) Handles btnLapJU.Click
        frmCetakJurnal.Show()
    End Sub

    Private Sub btnLapAJP_Click(sender As Object, e As EventArgs) Handles btnLapAJP.Click
        frmCetakJurnalAJP.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmLogin.ShowDialog()
    End Sub
End Class