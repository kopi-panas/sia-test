Imports System.Data.OleDb
Public Class frmCetakJurnal

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub SetCboPeriodeJU()
        Dim mTahun As String
        Dim mPeriode As String

        mTahun = Format(Now.Year)
        mPeriode = mTahun

        Try
            Query = "SELECT DISTINCT hJurnal.Periode, IIf(Right([Periode],2)= '" & "01" & "', '" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) AS Bulan FROM(hJurnal) GROUP BY hJurnal.Periode, IIf(Right([Periode],2)='" & "01" & "','" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) ORDER BY hJurnal.Periode Desc"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            cboPeriodeJU.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With cboPeriodeJU
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0) & " : " & dsData.Tables(0).Rows(a).Item(1))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetCboPeriodeBB()
        Dim mTahun As String
        Dim mPeriode As String

        mTahun = Format(Now.Year) ' FormatDateTime(Now, DateFormat.ShortDate)
        mPeriode = mTahun 'Mid(mTahun, 7, 4)

        Try
            Query = "SELECT DISTINCT BukuBesar.Periode, IIf(Right([Periode],2)= '" & "01" & "', '" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) AS Bulan FROM(BukuBesar) GROUP BY BukuBesar.Periode, IIf(Right([Periode],2)='" & "01" & "','" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) ORDER BY BukuBesar.Periode Desc"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            cboPeriodeBB.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With cboPeriodeBB
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0) & " : " & dsData.Tables(0).Rows(a).Item(1))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetCboPeriodeNS()
        Dim mTahun As String
        Dim mPeriode As String

        mTahun = Format(Now.Year) ' FormatDateTime(Now, DateFormat.ShortDate)
        mPeriode = mTahun 'Mid(mTahun, 7, 4)

        Try
            Query = "SELECT DISTINCT NeracaSaldo.Periode, IIf(Right([Periode],2)= '" & "01" & "', '" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) AS Bulan FROM(NeracaSaldo) GROUP BY NeracaSaldo.Periode, IIf(Right([Periode],2)='" & "01" & "','" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "'))))))))))))  ORDER BY NeracaSaldo.Periode Desc"

            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            cboPeriodeNS.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With cboPeriodeNS
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0) & " : " & dsData.Tables(0).Rows(a).Item(1))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdCetakJU_Click(sender As Object, e As EventArgs) Handles cmdCetakJU.Click
        If Len(cboPeriodeJU.Text) = 0 Then
            MsgBox("Pilih periode yang akan dicetak", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriodeJU.Focus()
        Else
            Try
                frmRptJurnalUmum.CrystalReportViewer1.SelectionFormula = "{hJurnal.Periode} = '" & Mid(cboPeriodeJU.Text, 1, 6) & "'"
                frmRptJurnalUmum.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptJurnalUmum.CrystalReportViewer1.RefreshReport()
                frmRptJurnalUmum.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdCetakNS_Click(sender As Object, e As EventArgs) Handles cmdCetakNS.Click
        If Len(cboPeriodeNS.Text) = 0 Then
            MsgBox("Pilih periode yang akan dicetak", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriodeNS.Focus()
        Else
            Try
                frmRptNeracaSaldo.CrystalReportViewer1.SelectionFormula = "{NeracaSaldo.Periode} = '" & Mid(cboPeriodeNS.Text, 1, 6) & "'"
                frmRptNeracaSaldo.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptNeracaSaldo.CrystalReportViewer1.RefreshReport()
                frmRptNeracaSaldo.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdCetakBB_Click(sender As Object, e As EventArgs) Handles cmdCetakBB.Click
        If Len(cboPeriodeBB.Text) = 0 Then
            MsgBox("Pilih periode yang akan dicetak", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriodeBB.Focus()
        Else
            Try
                frmRptBukuBesar.CrystalReportViewer1.SelectionFormula = "{BukuBesar.Periode} = '" & Mid(cboPeriodeBB.Text, 1, 6) & "'"
                frmRptBukuBesar.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptBukuBesar.CrystalReportViewer1.RefreshReport()
                frmRptBukuBesar.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdJU_Click(sender As Object, e As EventArgs) Handles cmdJU.Click
        cmdJU.BackColor = Color.Aqua
        cmdBB.BackColor = Color.White
        cmdNS.BackColor = Color.White
        jurnalumum.Visible = True
        bukubesar.Visible = False
        neracasaldo.Visible = False
        cmdCetakJU.Focus()
    End Sub

    Private Sub cmdBB_Click(sender As Object, e As EventArgs) Handles cmdBB.Click
        cmdBB.BackColor = Color.Aqua
        cmdJU.BackColor = Color.White
        cmdNS.BackColor = Color.White
        bukubesar.Visible = True
        jurnalumum.Visible = False
        neracasaldo.Visible = False
        cmdCetakBB.Focus()
    End Sub

    Private Sub cmdNS_Click(sender As Object, e As EventArgs) Handles cmdNS.Click
        cmdNS.BackColor = Color.Aqua
        cmdBB.BackColor = Color.White
        cmdJU.BackColor = Color.White
        neracasaldo.Visible = True
        jurnalumum.Visible = False
        bukubesar.Visible = False
        cmdCetakNS.Focus()
    End Sub

    Private Sub frmCetakJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmdJU.BackColor = Color.Aqua
            cmdNS.BackColor = Color.White
            cmdBB.BackColor = Color.White

            KoneksiKeAccess()
            SetCboPeriodeJU()
            SetCboPeriodeBB()
            SetCboPeriodeNS()
            cmdCetakJU.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class