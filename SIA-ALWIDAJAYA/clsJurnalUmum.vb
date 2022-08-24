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
            mNoTransaksi = frmJurnalUmum.lblNoTransaksi.Text
            mPeriode = frmJurnalUmum.lblPeriode.Text
            mTglTransaksi = frmJurnalUmum.txtTgl.Value
            mKeterangan = frmJurnalUmum.txtKeterangan.Text

            Query = "INSERT INTO hJurnal VALUES('" & mNoTransaksi & "', '" & mPeriode & "' , '" & mTglTransaksi & "', '" & mKeterangan & "', '" & "UnPosted" & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            'InsertBukuBesar()
            'Query = "SELECT DISTINCT hJurnal.Periode, hJurnal.Status FROM hJurnal WHERE (((hJurnal.Periode)='" & mPeriode & "') AND ((hJurnal.Status)='" & "UnPosted" & "'))"
            'daData = New OleDbDataAdapter(Query, CONN)
            'dsData = New DataSet
            'daData.Fill(dsData)

            'If dsData.Tables(0).Rows.Count = 0 Then
            '    InsertSaldoBulanlalu()
            'Else
            '    InsertSaldoBulanlalu()
            '    Query = "INSERT INTO BukuBesar SELECT hJurnal.Periode, hJurnal.NoTransaksi, hJurnal.TglTransaksi, dJurnal.NoPerkiraan, hJurnal.Keterangan, dJurnal.DK, dJurnal.Debet, dJurnal.Kredit, hJurnal.Status FROM (dJurnal LEFT JOIN hJurnal ON dJurnal.NoTransaksi = hJurnal.NoTransaksi) LEFT JOIN tblMasterPerkiraan ON dJurnal.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE (((hJurnal.Periode)='" & mPeriode & "') AND ((hJurnal.Status)= '" & "UnPosted" & "'))"
            '    daData = New OleDbDataAdapter(Query, CONN)
            '    dsData = New DataSet
            '    daData.Fill(dsData)
            'End If
            Return Query
        Catch ex As Exception
            Return Query
        End Try
    End Function

    Public Function SimpanData()
        Try
            mNoTransaksi = frmJurnalUmum.lblNoTransaksi.Text
            mNoPerkiraan = frmJurnalUmum.txtNoPerkiraan.Text
            DK = frmJurnalUmum.mDK
            mDebet = frmJurnalUmum.txtDebet.Text
            mKredit = frmJurnalUmum.txtKredit.Text

            Query = "INSERT INTO dJurnal VALUES('" & mNoTransaksi & "','" & mNoPerkiraan & "',  '" & DK & "' , '" & mDebet & "' ,'" & mKredit & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            frmPerkiraan.IsiList()
            'InsertBukuBesar()
            Return Query
        Catch ex As Exception
            MsgBox("Data tidak bisa tersimpan karena NoAkun sudah ada!", MsgBoxStyle.Exclamation, "Error")
            frmPerkiraan.txtNoPerkiraan.Focus()
            Return Query
        End Try
    End Function

    Public Sub InsertSaldoBulanlalu()
        mPeriode = frmJurnalUmum.lblPeriode.Text
        Try
            Query = "INSERT INTO BukuBesar SELECT tmpSaldoBlnLalu.Periode, '" & "SBL-" & "' & [Periode] AS NoTransaksi, tmpSaldoBlnLalu.TglTransaksi, tmpSaldoBlnLalu.NoPerkiraan, tmpSaldoBlnLalu.Keterangan, tmpSaldoBlnLalu.DK, tmpSaldoBlnLalu.Debet, tmpSaldoBlnLalu.Kredit, tmpSaldoBlnLalu.Status FROM(tmpSaldoBlnLalu) WHERE(((tmpSaldoBlnLalu.Periode) = '" & mPeriode & "') And ((tmpSaldoBlnLalu.Status) = '" & "UnPosted" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub InsertBukuBesar()
        mPeriode = frmJurnalUmum.lblPeriode.Text
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
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub BukuBesar()
        mPeriode = frmJurnalUmum.lblPeriode.Text
        If dsData.Tables(0).Rows.Count = 0 Then
            InsertBukuBesar()
        Else
            KoneksiKeAccess()
            Dim edit As String = "UPDATE BukuBesar SET NoTransaksi ='" & mNoTransaksi & "',TglTransaksi = '" & mTglTransaksi & "',NoPerkiraan = '" & mNoPerkiraan & "',Keterangan = '" & mKeterangan & "',DK = '" & DK & "',Debet = '" & mDebet & "',Kredit = '" & mKredit & "',Status = '" & "UnPosted" & "' WHERE Periode = '" & mPeriode & "'"
            Command = New OleDbCommand(edit, CONN)
            Command.ExecuteNonQuery()
        End If
    End Sub

    Public Function EditDataHJurnal()
        Try
            mNoTransaksi = frmJurnalUmum.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalUmum.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalUmum.lblNoTransaksi.Text
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
            mNoTransaksi = frmJurnalUmum.lblNoTransaksi.Text
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
