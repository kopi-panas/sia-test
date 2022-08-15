Imports System.Data.OleDb
Public Class frmCetakJurnalAJP

    Private Sub SetCboPeriodeJP()
        Dim mTahun As String
        Dim mPeriode As String

        mTahun = Format(Now.Year)
        mPeriode = mTahun

        Try
            Query = "SELECT DISTINCT hJurnalAJP.Periode, IIf(Right([Periode],2)= '" & "01" & "', '" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) AS Bulan FROM(hJurnalAJP) GROUP BY hJurnalAJP.Periode, IIf(Right([Periode],2)='" & "01" & "','" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) ORDER BY hJurnalAJP.Periode Desc"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            cboPeriodeJP.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With cboPeriodeJP
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0) & " : " & dsData.Tables(0).Rows(a).Item(1))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetCboPeriodeBB()
        Dim mTahun As String
        Dim mPeriode As String

        mTahun = Format(Now.Year) 'FormatDateTime(Now, DateFormat.ShortDate)
        mPeriode = mTahun 'Mid(mTahun, 7, 4)

        Try
            Query = "SELECT DISTINCT BukuBesarAJP.Periode, IIf(Right([Periode],2)= '" & "01" & "', '" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) AS Bulan FROM(BukuBesarAJP) GROUP BY BukuBesarAJP.Periode, IIf(Right([Periode],2)='" & "01" & "','" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) HAVING(((Left([Periode], 4)) = '" & mPeriode & "')) ORDER BY BukuBesarAJP.Periode Desc"
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
        mPeriode = mTahun ' Mid(mTahun, 7, 4)

        Try
            Query = "SELECT DISTINCT tblAJP.Periode, IIf(Right([Periode],2)= '" & "01" & "', '" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) AS Bulan FROM(tblAJP) GROUP BY tblAJP.Periode, IIf(Right([Periode],2)='" & "01" & "','" & "Januari" & "',IIf(Right([Periode],2)='" & "02" & "','" & "Februari" & "',IIf(Right([Periode],2)='" & "03" & "','" & "Maret" & "',IIf(Right([Periode],2)='" & "04" & "','" & "April" & "',IIf(Right([Periode],2)='" & "05" & "','" & "Mei" & "',IIf(Right([Periode],2)='" & "06" & "','" & "Juni" & "',IIf(Right([Periode],2)='" & "07" & "','" & "Juli" & "',IIf(Right([Periode],2)='" & "08" & "','" & "Agustus" & "',IIf(Right([Periode],2)='" & "09" & "','" & "September" & "',IIf(Right([Periode],2)='" & "10" & "','" & "Oktober" & "',IIf(Right([Periode],2)='" & "11" & "','" & "November" & "',IIf(Right([Periode],2)='" & "12" & "','" & "Desember" & "','" & "Bulan tidak dikenal" & "')))))))))))) ORDER BY tblAJP.Periode Desc"
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

    Private Sub frmCetakJurnalAJP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmdBB.BackColor = Color.White
            cmdJP.BackColor = Color.LightSteelBlue
            cmdNS.BackColor = Color.White
            KoneksiKeAccess()
            SetCboPeriodeJP()
            SetCboPeriodeBB()
            SetCboPeriodeNS()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub cmdCetakJP_Click(sender As Object, e As EventArgs) Handles cmdCetakJP.Click
        If Len(cboPeriodeJP.Text) = 0 Then
            MsgBox("Pilih periode yang akan dicetak", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriodeJP.Focus()
        Else
            Try
                frmRptAJP.CrystalReportViewer1.SelectionFormula = "{hJurnalAJP.Periode} = '" & Mid(cboPeriodeJP.Text, 1, 6) & "'"
                frmRptAJP.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptAJP.CrystalReportViewer1.RefreshReport()
                frmRptAJP.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdCetakNS_Click(sender As Object, e As EventArgs)
        If Len(cboPeriodeNS.Text) = 0 Then
            MsgBox("Pilih periode yang akan dicetak", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriodeNS.Focus()
        Else
            Try
                frmRptNeracaSaldoAJP.CrystalReportViewer1.SelectionFormula = "{tblAJP.Periode} = '" & Mid(cboPeriodeNS.Text, 1, 6) & "'"
                frmRptNeracaSaldoAJP.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptNeracaSaldoAJP.CrystalReportViewer1.RefreshReport()
                frmRptNeracaSaldoAJP.ShowDialog()
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
                frmRptBukubesarAJP.CrystalReportViewer1.SelectionFormula = "{BukuBesarAJP.Periode} = '" & Mid(cboPeriodeBB.Text, 1, 6) & "'"
                frmRptBukubesarAJP.CrystalReportViewer1.Dock = DockStyle.Fill
                frmRptBukubesarAJP.CrystalReportViewer1.RefreshReport()
                frmRptBukubesarAJP.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdJP_Click(sender As Object, e As EventArgs) Handles cmdJP.Click
        cmdJP.BackColor = Color.LightSteelBlue
        cmdNS.BackColor = Color.White
        cmdBB.BackColor = Color.White
        jurnalpenyesuaian.Visible = True
        bukubesar.Visible = False
        neracasaldo.Visible = False
    End Sub

    Private Sub cmdBB_Click(sender As Object, e As EventArgs) Handles cmdBB.Click
        cmdBB.BackColor = Color.LightSteelBlue
        cmdJP.BackColor = Color.White
        cmdNS.BackColor = Color.White
        bukubesar.Visible = True
        jurnalpenyesuaian.Visible = False
        neracasaldo.Visible = False
    End Sub

    Private Sub cmdNS_Click(sender As Object, e As EventArgs) Handles cmdNS.Click
        cmdNS.BackColor = Color.LightSteelBlue
        cmdBB.BackColor = Color.White
        cmdJP.BackColor = Color.White
        neracasaldo.Visible = True
        jurnalpenyesuaian.Visible = False
        bukubesar.Visible = False
    End Sub

End Class