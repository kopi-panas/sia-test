Imports System.Data.OleDb
Public Class frmSubJurnalUmum

    Private Sub PosisiList()
        ListView.Columns.Clear()
        With ListView.Columns
            .Add("Periode", 0)
            .Add("Tanggal", 90, HorizontalAlignment.Right)
            .Add("No.Transaksi", 110)
            .Add("Keterangan", 325)
            .Add("Status", 0)
        End With
    End Sub

    Private Sub IsiList()
        Try
            Query = "SELECT hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status FROM(hJurnal) GROUP BY hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status HAVING(((hJurnal.Periode) = '" & cboPeriode.Text & "')) ORDER BY hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status "

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
                        .Items(a).BackColor = Color.White
                    Else
                        .Items(a).BackColor = Color.Transparent
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AmbilData()
        Try
            With ListView.SelectedItems
                frmJurnalUmum.lblPeriode.Text = .Item(0).SubItems(0).Text
                frmJurnalUmum.txtTgl.Text = .Item(0).SubItems(1).Text
                frmJurnalUmum.txtNoTransaksi.Text = .Item(0).SubItems(2).Text
                frmJurnalUmum.txtKeterangan.Text = .Item(0).SubItems(3).Text
                frmJurnalUmum.mPosted = .Item(0).SubItems(4).Text
                frmJurnalUmum.cmdTambah.Enabled = False
                frmJurnalUmum.cmdEdit.Enabled = True
                frmJurnalUmum.cmdHapus.Enabled = True
                frmJurnalUmum.cmdKeluar.Text = "&Batal"
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

    Private Sub frmSubJurnalUmum_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtNoTransaksi.Focus()
    End Sub

    Private Sub frmSubJurnalUmum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiKeAccess()
            cboPeriode.Text = frmJurnalUmum.lblPeriode.Text

            PosisiList()
            IsiList()
            IsiComboPeriode()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub ListView_DoubleClick(sender As Object, e As EventArgs) Handles ListView.DoubleClick
        AmbilData()
        frmJurnalUmum.IsiListGridDJurnal()
        frmJurnalUmum.TotalDebetKredit()
        Me.Close()
    End Sub

    Private Sub ListView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListView.KeyPress
        If e.KeyChar = Chr(13) Then
            AmbilData()
            frmJurnalUmum.IsiListGridDJurnal()
            frmJurnalUmum.TotalDebetKredit()
            Me.Close()
        End If
    End Sub

    Private Sub cmdYa_Click(sender As Object, e As EventArgs) Handles cmdYa.Click
        AmbilData()
        frmJurnalUmum.IsiListGridDJurnal()
        frmJurnalUmum.TotalDebetKredit()
        Me.Close()
    End Sub

    Private Sub txtNoTransaksi_TextChanged(sender As Object, e As EventArgs) Handles txtNoTransaksi.TextChanged
        Try
            Query = "SELECT hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status FROM(hJurnal) GROUP BY hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status HAVING(((hJurnal.Periode) = '" & cboPeriode.Text & "') And ((hJurnal.NoTransaksi) Like '" & txtNoTransaksi.Text & "%" & "')) ORDER BY hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status"
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
                        .Items(a).BackColor = Color.Transparent
                    Else
                        .Items(a).BackColor = Color.Transparent
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboPeriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriode.SelectedIndexChanged
        Try
            Query = "SELECT hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status FROM(hJurnal) GROUP BY hJurnal.Periode, hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status HAVING(((hJurnal.Periode) = '" & cboPeriode.Text & "')) ORDER BY hJurnal.Periode DESC , hJurnal.TglTransaksi, hJurnal.NoTransaksi, hJurnal.Keterangan, hJurnal.Status"
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
                        .Items(a).BackColor = Color.Transparent
                    Else
                        .Items(a).BackColor = Color.Transparent
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

End Class