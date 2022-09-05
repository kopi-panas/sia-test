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
            mNoTransaksi = frmJurnalPenyesuaian.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalPenyesuaian.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalPenyesuaian.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalPenyesuaian.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalPenyesuaian.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalPenyesuaian.lblNoTransaksi.Text
            Query = "DELETE FROM dJurnalAJP WHERE NoTransaksi = '" & mNoTransaksi & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub InsertSaldoBulanlalu()
        mPeriode = frmJurnalPenyesuaian.lblPeriode.Text
        Try
            Query = "INSERT INTO BukuBesar SELECT tmpSaldoBlnLalu.Periode, '" & "SBL-" & "' & [Periode] AS NoTransaksi, tmpSaldoBlnLalu.TglTransaksi, tmpSaldoBlnLalu.NoPerkiraan, tmpSaldoBlnLalu.Keterangan, tmpSaldoBlnLalu.DK, tmpSaldoBlnLalu.Debet, tmpSaldoBlnLalu.Kredit, tmpSaldoBlnLalu.Status FROM(tmpSaldoBlnLalu) WHERE(((tmpSaldoBlnLalu.Periode) = '" & mPeriode & "') And ((tmpSaldoBlnLalu.Status) = '" & "UnPosted" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub InsertBukuBesar()
        mPeriode = frmJurnalPenyesuaian.lblPeriode.Text
        Try
            Query = "SELECT DISTINCT hJurnal.Periode, hJurnal.Status FROM hJurnal WHERE (((hJurnal.Periode)='" & mPeriode & "') AND ((hJurnal.Status)='" & "UnPosted" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                InsertSaldoBulanlalu()
            Else
                InsertSaldoBulanlalu()
                Query = "INSERT INTO BukuBesar SELECT hJurnal.Periode, hJurnal.NoTransaksi, hJurnal.TglTransaksi, dJurnal.NoPerkiraan, hJurnal.Keterangan, dJurnal.DK, dJurnal.Debet, dJurnal.Kredit, hJurnal.Status FROM (dJurnal LEFT JOIN hJurnal ON dJurnal.NoTransaksi = hJurnal.NoTransaksi) LEFT JOIN tblMasterPerkiraan ON dJurnal.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE (((hJurnal.Periode)='" & mPeriode & "') AND ((hJurnal.Status)= '" & "UnPosted" & "'))"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)

                Query = "INSERT INTO BukuBesar SELECT hJurnalAJP.Periode, hJurnalAJP.NoTransaksi, hJurnalAJP.TglTransaksi, dJurnalAJP.NoPerkiraan, hJurnalAJP.Keterangan, dJurnalAJP.DK, dJurnalAJP.Debet, dJurnalAJP.Kredit, hJurnalAJP.Status FROM (dJurnalAJP LEFT JOIN hJurnalAJP ON dJurnalAJP.NoTransaksi = hJurnalAJP.NoTransaksi) LEFT JOIN tblMasterPerkiraan ON dJurnalAJP.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE (((hJurnalAJP.Periode) = '" & mPeriode & "') AND ((hJurnalAJP.Status)= '" & "UnPosted" & "'))"
                daData = New OleDbDataAdapter(Query, CONN)
                dsData = New DataSet
                daData.Fill(dsData)
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
