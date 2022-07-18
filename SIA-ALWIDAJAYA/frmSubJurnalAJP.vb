Imports System.Data.OleDb
Public Class frmSubJurnalAJP

    Private Sub PosisiList()
        With ListView.Columns
            .Add("Periode", 0)
            .Add("Tanggal", 90)
            .Add("No.Transaksi", 110)
            .Add("Keterangan", 325)
            .Add("Status", 0)
        End With
    End Sub

    Private Sub IsiList()
        Try
            Query = "SELECT hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status FROM(hJurnalAJP) GROUP BY hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status HAVING(((hJurnalAJP.Periode) = '" & cboPeriode.Text & "')) ORDER BY hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status "
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(1), "dd/MM/yyyy"))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.LightSteelBlue
                    Else
                        .Items(a).BackColor = Color.LightBlue
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AmabilData()
        Try
            With ListView.SelectedItems
                frmJurnalPenyesuaian.lblPeriode.Text = .Item(0).SubItems(0).Text
                frmJurnalPenyesuaian.txtTgl.Text = .Item(0).SubItems(1).Text
                frmJurnalPenyesuaian.txtNoTransaksi.Text = .Item(0).SubItems(2).Text
                frmJurnalPenyesuaian.txtKeterangan.Text = .Item(0).SubItems(3).Text
                frmJurnalPenyesuaian.mPosted = .Item(0).SubItems(4).Text
                frmJurnalPenyesuaian.cmdTambah.Text = "&Tambah"
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub IsiComboPeriode()
        Try
            Query = "SELECT * FROM tblMasterPeriode ORDER BY Periode Desc"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            cboPeriode.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With cboPeriode
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSubJurnalAJP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiKeAccess()
            cboPeriode.Text = frmJurnalPenyesuaian.lblPeriode.Text

            PosisiList()
            IsiList()
            IsiComboPeriode()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        Dispose()
    End Sub

    Private Sub ListView_DoubleClick(sender As Object, e As EventArgs) Handles ListView.DoubleClick
        AmabilData()
        frmJurnalPenyesuaian.IsiListGridDJurnal()
        frmJurnalPenyesuaian.TotalDebetKredit()
        Dispose()
    End Sub

    Private Sub ListView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListView.KeyPress
        If e.KeyChar = Chr(13) Then
            AmabilData()
            frmJurnalPenyesuaian.IsiListGridDJurnal()
            frmJurnalPenyesuaian.TotalDebetKredit()
            Dispose()
        End If
    End Sub

    Private Sub cmdYa_Click(sender As Object, e As EventArgs) Handles cmdYa.Click
        AmabilData()
        frmJurnalPenyesuaian.IsiListGridDJurnal()
        frmJurnalPenyesuaian.TotalDebetKredit()
        Dispose()
    End Sub

    Private Sub txtNoTransaksi_TextChanged(sender As Object, e As EventArgs) Handles txtNoTransaksi.TextChanged
        Try
            Query = "SELECT hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status FROM(hJurnalAJP) GROUP BY hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status HAVING(((hJurnalAJP.Periode) = '" & cboPeriode.Text & "') And ((hJurnalAJP.NoTransaksi) Like '" & txtNoTransaksi.Text & "%" & "')) ORDER BY hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(1), "dd/MM/yyyy"))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.LightSteelBlue
                    Else
                        .Items(a).BackColor = Color.LightBlue
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboPeriode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPeriode.KeyPress
        If e.KeyChar = Chr(13) Then
            If cboPeriode.Text = "" Then
                MsgBox("Periode kosong", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan Periode")
                cboPeriode.Focus()
            Else
                txtNoTransaksi.Focus()
            End If
        End If
    End Sub

    Private Sub cboPeriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriode.SelectedIndexChanged
        Try
            Query = "SELECT hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status FROM(hJurnalAJP) GROUP BY hJurnalAJP.Periode, hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status HAVING(((hJurnalAJP.Periode) = '" & cboPeriode.Text & "')) ORDER BY hJurnalAJP.Periode DESC , hJurnalAJP.TglTransaksi, hJurnalAJP.NoTransaksi, hJurnalAJP.Keterangan, hJurnalAJP.Status"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(1), "dd/MM/yyyy"))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.LightSteelBlue
                    Else
                        .Items(a).BackColor = Color.LightBlue
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class