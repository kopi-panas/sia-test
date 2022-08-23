Imports System.Data.OleDb
Public Class clsSaldoBlnLalu

    Private mPeriode As String
    Private mTgl As Date
    Private mKodeRekening As String
    Private tempDK As String
    Private mDebet As Long
    Private mKredit As Long

    Public Sub TambahData()
        With frmTransaksiSaldoBlnLalu
            .BersihkanIsian()
            .txtKodeRekening.Focus()
        End With
    End Sub

    Public Function SimpanData()
        Try
            mPeriode = frmTransaksiSaldoBlnLalu.cboPeriode.Text
            mTgl = frmTransaksiSaldoBlnLalu.txtTgl.Value
            mKodeRekening = frmTransaksiSaldoBlnLalu.txtKodeRekening.Text
            tempDK = frmTransaksiSaldoBlnLalu.mDK
            mDebet = frmTransaksiSaldoBlnLalu.txtDebet.Text
            mKredit = frmTransaksiSaldoBlnLalu.txtKredit.Text

            Query = "INSERT INTO tmpSaldoBlnLalu VALUES('" & mPeriode & "', '" & mTgl & "', '" & mKodeRekening & "', '" & tempDK & "', '" & mDebet & "','" & mKredit & "', '" & "UnPosted" & "', '" & "Saldo bulan lalu" & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return Query
        End Try
    End Function

    Public Function EditData()
        Try
            mKodeRekening = frmTransaksiSaldoBlnLalu.txtKodeRekening.Text
            mDebet = frmTransaksiSaldoBlnLalu.txtDebet.Text
            mKredit = frmTransaksiSaldoBlnLalu.txtKredit.Text

            Query = "UPDATE tmpSaldoBlnLalu SET  Debet = '" & mDebet & "', Kredit = '" & mKredit & "'  WHERE NoPerkiraan = '" & mKodeRekening & "'"
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
            mPeriode = frmTransaksiSaldoBlnLalu.cboPeriode.Text
            mKodeRekening = frmTransaksiSaldoBlnLalu.txtKodeRekening.Text

            Query = "DELETE FROM tmpSaldoBlnLalu WHERE NoPerkiraan = '" & mKodeRekening & "' AND Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
