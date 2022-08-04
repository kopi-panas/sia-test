Imports System.Data.OleDb
Public Class clsJurnalPenyesuaian

    Private mNoTransaksi As String
    Private mPeriode As String
    Private mTglTransaksi As Date
    Private mKeterangan As String
    Private mNoPerkiraan As String
    Private DK As String
    Private mDebet As Long
    Private mKredit As Long

    Public Sub TambahData()
        With frmJurnalPenyesuaian
            .BersihkanIsian()
            .BersihkanIsianGrid()
            .IsiListGridDJurnal()
            .txtTgl.Focus()
        End With
    End Sub

    Public Function SimpanDatahJurnal()
        Try
            mNoTransaksi = frmJurnalPenyesuaian.txtNoTransaksi.Text
            mPeriode = frmJurnalPenyesuaian.lblPeriode.Text
            mTglTransaksi = frmJurnalPenyesuaian.txtTgl.Value
            mKeterangan = frmJurnalPenyesuaian.txtKeterangan.Text

            Query = "INSERT INTO hJurnalAJP VALUES('" & mNoTransaksi & "', '" & mPeriode & "' , '" & mTglTransaksi & "', '" & mKeterangan & "', '" & "UnPosted" & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return Query
        End Try
    End Function

    Public Function SimpanData()
        Try
            mNoTransaksi = frmJurnalPenyesuaian.txtNoTransaksi.Text
            mNoPerkiraan = frmJurnalPenyesuaian.txtNoPerkiraan.Text
            DK = frmJurnalPenyesuaian.mDK
            mDebet = frmJurnalPenyesuaian.txtDebet.Text
            mKredit = frmJurnalPenyesuaian.txtKredit.Text

            Query = "INSERT INTO dJurnalAJP VALUES('" & mNoTransaksi & "','" & mNoPerkiraan & "', '" & DK & "' , '" & mDebet & "' ,'" & mKredit & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            frmPerkiraan.IsiList()
            Return Query
        Catch ex As Exception
            MsgBox("Data tidak bisa tersimpan karena NoAkun sudah ada...", MsgBoxStyle.Exclamation, "Error")
            frmPerkiraan.txtNoPerkiraan.Focus()
            Return Query
        End Try
    End Function

    Public Function EditDatahJurnal()
        Try
            mNoTransaksi = frmJurnalPenyesuaian.txtNoTransaksi.Text
            mTglTransaksi = frmJurnalPenyesuaian.txtTgl.Value
            mKeterangan = frmJurnalPenyesuaian.txtKeterangan.Text

            Query = "UPDATE hJurnalAJP SET  TglTransaksi = '" & mTglTransaksi & "', Keterangan = '" & mKeterangan & "' WHERE NoTransaksi = '" & mNoTransaksi & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function EditData()
        Try
            DK = frmJurnalPenyesuaian.mDK
            mDebet = frmJurnalPenyesuaian.txtDebet.Text
            mKredit = frmJurnalPenyesuaian.txtKredit.Text
            mNoTransaksi = frmJurnalPenyesuaian.txtNoTransaksi.Text
            mNoPerkiraan = frmJurnalPenyesuaian.txtNoPerkiraan.Text

            Query = "UPDATE dJurnalAJP SET  DK = '" & DK & "', Debet = '" & mDebet & "', Kredit = '" & mKredit & "' WHERE NoTransaksi = '" & mNoTransaksi & "' AND NoPerkiraan = '" & mNoPerkiraan & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function HapusDatahJurnal()
        Try
            mNoTransaksi = frmJurnalPenyesuaian.txtNoTransaksi.Text
            Query = "DELETE FROM hJurnalAJP WHERE NoTransaksi = '" & mNoTransaksi & "'"
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
            mNoTransaksi = frmJurnalPenyesuaian.txtNoTransaksi.Text
            Query = "DELETE FROM dJurnalAJP WHERE NoTransaksi = '" & mNoTransaksi & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
