Imports System.Data.OleDb
Public Class clsJurnalUmum

    Private mNoTransaksi As String
    Private mPeriode As String
    Private mTglTransaksi As Date
    Private mKeterangan As String
    Private mNoPerkiraan As String
    Private DK As String
    Private mDebet As Long
    Private mKredit As Long

    Public Sub TambahData()
        With frmJurnalUmum
            .BersihkanIsian()
            .BersihkanIsianGrid()
            .IsiListGridDJurnal()
            .txtTgl.Focus()
        End With
    End Sub

    Public Function SimpanDataHJurnal()
        Try
            mNoTransaksi = frmJurnalUmum.txtNoTransaksi.Text
            mPeriode = frmJurnalUmum.lblPeriode.Text
            mTglTransaksi = frmJurnalUmum.txtTgl.Value
            mKeterangan = frmJurnalUmum.txtKeterangan.Text

            Query = "INSERT INTO hJurnal VALUES('" & mNoTransaksi & "', '" & mPeriode & "' , '" & mTglTransaksi & "', '" & mKeterangan & "', '" & "UnPosted" & "')"
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
            mNoTransaksi = frmJurnalUmum.txtNoTransaksi.Text
            mNoPerkiraan = frmJurnalUmum.txtNoPerkiraan.Text
            DK = frmJurnalUmum.mDK
            mDebet = frmJurnalUmum.txtDebet.Text
            mKredit = frmJurnalUmum.txtKredit.Text

            Query = "INSERT INTO dJurnal VALUES('" & mNoTransaksi & "','" & mNoPerkiraan & "',  '" & DK & "' , '" & mDebet & "' ,'" & mKredit & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            frmPerkiraan.IsiList()
            Return Query
        Catch ex As Exception
            MsgBox("Data tidak bisa tersimpan karena NoPerkiraan sudah ada...", MsgBoxStyle.Exclamation, "Error")
            frmPerkiraan.txtNoPerkiraan.Focus()
            Return Query
        End Try
    End Function

    Public Function EditDataHJurnal()
        Try
            mNoTransaksi = frmJurnalUmum.txtNoTransaksi.Text
            mTglTransaksi = Format(frmJurnalUmum.txtTgl.Value, "dd/MM/yyyy")
            mKeterangan = frmJurnalUmum.txtKeterangan.Text

            Query = "UPDATE hJurnal SET  TglTransaksi = '" & mTglTransaksi & "', Keterangan = '" & mKeterangan & "' WHERE NoTransaksi = '" & mNoTransaksi & "'"
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
            DK = frmJurnalUmum.mDK
            mDebet = frmJurnalUmum.txtDebet.Text
            mKredit = frmJurnalUmum.txtKredit.Text
            mNoTransaksi = frmJurnalUmum.txtNoTransaksi.Text
            mNoPerkiraan = frmJurnalUmum.txtNoPerkiraan.Text

            Query = "UPDATE dJurnal SET  DK = '" & DK & "', Debet = '" & mDebet & "', Kredit = '" & mKredit & "' WHERE NoTransaksi = '" & mNoTransaksi & "' AND NoPerkiraan = '" & mNoPerkiraan & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function HapusDataHJurnal()
        Try
            mNoTransaksi = frmJurnalUmum.txtNoTransaksi.Text
            Query = "DELETE FROM hJurnal WHERE NoTransaksi = '" & mNoTransaksi & "'"
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
            mNoTransaksi = frmJurnalUmum.txtNoTransaksi.Text
            Query = "DELETE FROM dJurnal WHERE NoTransaksi = '" & mNoTransaksi & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
