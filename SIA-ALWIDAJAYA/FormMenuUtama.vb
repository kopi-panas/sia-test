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
End Class