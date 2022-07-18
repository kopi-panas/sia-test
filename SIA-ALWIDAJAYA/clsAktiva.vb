Imports System.Data.OleDb
Public Class clsAktiva

    Private KodePerkiraan As String
    Private KodePerkiraan2 As String
    Private KodeKelompok As Char
    Private TglPerolehan As Date
    Private HargaPerolehan As Long
    Private UmurEkonomis As Integer
    Private TglPensiun As Date
    Private NilaiResidu As Long
    Private Penyusutan As String
    Private NoSeri As String
    Private TglTerhitung As Date
    Private Akumulasi As Long
    Private Beban As Long
    Private NilaiBuku As Long
    Private BebanPerBulan As Long

    Public Sub TambahData()
        With frmAktivaTetap
            .cboKelompok.Focus()
        End With
    End Sub

    Public Function SimpanData()
        Try
            KodePerkiraan = Microsoft.VisualBasic.Left(frmAktivaTetap.cboAkumulasi.Text, 5)
            KodePerkiraan2 = Microsoft.VisualBasic.Left(frmAktivaTetap.lblNama.Text, 5)
            KodeKelompok = Microsoft.VisualBasic.Left(frmAktivaTetap.cboKelompok.Text, 1)
            TglPerolehan = frmAktivaTetap.tglPerolehan.Text
            HargaPerolehan = frmAktivaTetap.txtHargaPerolehan.Text
            UmurEkonomis = frmAktivaTetap.txtUmur.Text
            TglPensiun = frmAktivaTetap.tglPensiun.Text
            NilaiResidu = frmAktivaTetap.txtNilaiResidu.Text
            Penyusutan = frmAktivaTetap.cboPenyusutan.Text
            If frmAktivaTetap.txtNoSeri.Text = "" Then
                NoSeri = "-"
            Else
                NoSeri = frmAktivaTetap.txtNoSeri.Text
            End If
            TglTerhitung = frmAktivaTetap.tglTerhitung.Text
            Akumulasi = frmAktivaTetap.txtAkumulasi.Text
            Beban = frmAktivaTetap.txtBeban.Text
            NilaiBuku = frmAktivaTetap.txtNilaiBuku.Text
            BebanPerBulan = frmAktivaTetap.lblBebanPerbulan.Text
            Query = "INSERT INTO tblAKtiva VALUES('" & KodePerkiraan & "', '" & KodePerkiraan2 & "', '" & KodeKelompok & "', '" & TglPerolehan & "', '" & HargaPerolehan & "', '" & UmurEkonomis & "' , '" & TglPensiun & "', '" & NilaiResidu & "' , '" & Penyusutan & "' , '" & NoSeri & "' , '" & TglTerhitung & "' , '" & Akumulasi & "' , '" & Beban & "' , '" & NilaiBuku & "' , '" & BebanPerBulan & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            MsgBox("Data tidak bisa tersimpan karena NoPerkiraan sudah ada...", MsgBoxStyle.Exclamation, "Error")
            frmPerkiraan.txtNoPerkiraan.Focus()
            Return Query
        End Try
    End Function

    Public Function EditData()
        Try
            KodePerkiraan = Microsoft.VisualBasic.Left(frmAktivaTetap.cboAkumulasi.Text, 5)
            KodePerkiraan2 = Microsoft.VisualBasic.Left(frmAktivaTetap.lblNama.Text, 5)
            KodeKelompok = Microsoft.VisualBasic.Left(frmAktivaTetap.cboKelompok.Text, 1)
            TglPerolehan = frmAktivaTetap.tglPerolehan.Text
            HargaPerolehan = frmAktivaTetap.txtHargaPerolehan.Text
            UmurEkonomis = frmAktivaTetap.txtUmur.Text
            TglPensiun = frmAktivaTetap.tglPensiun.Text
            NilaiResidu = frmAktivaTetap.txtNilaiResidu.Text
            Penyusutan = frmAktivaTetap.cboPenyusutan.Text
            NoSeri = frmAktivaTetap.txtNoSeri.Text
            TglTerhitung = frmAktivaTetap.tglTerhitung.Text
            Akumulasi = frmAktivaTetap.txtAkumulasi.Text
            Beban = frmAktivaTetap.txtBeban.Text
            NilaiBuku = frmAktivaTetap.txtNilaiBuku.Text
            BebanPerBulan = frmAktivaTetap.lblBebanPerbulan.Text
            Query = "UPDATE tblAKtiva SET NoPerkiraan = '" & Microsoft.VisualBasic.Left(frmAktivaTetap.cboAkumulasi.Text, 5) & "', KodeKelompok = '" & KodeKelompok & "', TglPerolehan = '" & TglPerolehan & "', HargaPerolehan = '" & HargaPerolehan & "', UmurEkonomis ='" & UmurEkonomis & "' , TglPensiun ='" & TglPensiun & "', NilaiResidu = '" & NilaiResidu & "' , Penyusutan = '" & Penyusutan & "' , NoSeri = '" & NoSeri & "' , TglTerhitung = '" & TglTerhitung & "' , Akumulasi = '" & Akumulasi & "' , Beban = '" & Beban & "' , NilaiBuku = '" & NilaiBuku & "', BebanPerBulan = '" & BebanPerBulan & "' WHERE NoPerkiraan2 = '" & KodePerkiraan2 & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function HapusData()
        Try
            KodePerkiraan2 = Microsoft.VisualBasic.Left(frmAktivaTetap.lblNama.Text, 5)
            Query = "DELETE FROM tblAKtiva WHERE NoPerkiraan2 = '" & KodePerkiraan2 & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub Keluar()
        frmAktivaTetap.Dispose()
    End Sub

End Class
