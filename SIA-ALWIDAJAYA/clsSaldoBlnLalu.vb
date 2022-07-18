Imports System.Data.OleDb
Public Class clsSaldoBlnLalu

    Private mPeriode As String
    Private mTgl As Date
    Private mKodeRekening As String
    Private tempDK As String
    Private mDebet As Long
    Private mKredit As Long

    Public Sub TambahData()
        With frmTransaksiSaloBlnLalu
            .BersihkanIsian()
            .txtKodeRekening.Focus()
        End With
    End Sub

    Public Function SimpanData()
        Try
            mPeriode = frmTransaksiSaloBlnLalu.cboPeriode.Text
            mTgl = frmTransaksiSaloBlnLalu.txtTgl.Value
            mKodeRekening = frmTransaksiSaloBlnLalu.txtKodeRekening.Text
            tempDK = frmTransaksiSaloBlnLalu.mDK
            mDebet = frmTransaksiSaloBlnLalu.txtDebet.Text
            mKredit = frmTransaksiSaloBlnLalu.txtKredit.Text

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
            mKodeRekening = frmTransaksiSaloBlnLalu.txtKodeRekening.Text
            mDebet = frmTransaksiSaloBlnLalu.txtDebet.Text
            mKredit = frmTransaksiSaloBlnLalu.txtKredit.Text

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
            mPeriode = frmTransaksiSaloBlnLalu.cboPeriode.Text
            mKodeRekening = frmTransaksiSaloBlnLalu.txtKodeRekening.Text

            Query = "DELETE FROM tmpSaldoBlnLalu WHERE NoPerkiraan = '" & mKodeRekening & "' AND Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub Keluar()
        frmTransaksiSaloBlnLalu.Dispose()
    End Sub

End Class
