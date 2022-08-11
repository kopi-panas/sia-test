Imports System.Data.OleDb
Public Class frmMasterPeriode

    Dim mPosted As String

    Sub KondisiAwal()
        cboPeriode.Text = Format(Now.Year)
        txtTglDari.Text = Now
        txtTglSampai.Text = Now
        cmdTambah.Enabled = True
        cmdEdit.Enabled = False
        cmdSimpan.Enabled = False
        cmdHapus.Enabled = False
        cmdKeluar.Enabled = True
        cboPeriode.Focus()
        cmdKeluar.Text = "Keluar"
        cmdEdit.Text = "Edit"
        Tutup()
    End Sub

    Sub Buka()
        cboPeriode.Enabled = True
        txtTglDari.Enabled = True
        txtTglSampai.Enabled = True
    End Sub

    Sub Tutup()
        cboPeriode.Enabled = False
        txtTglDari.Enabled = False
        txtTglSampai.Enabled = False
    End Sub

    Public Sub PosisiList()
        With ListView.Columns
            .Add("Periode", 84)
            .Add("Dari Tgl", 100, HorizontalAlignment.Right)
            .Add("Sampai Tgl", 100, HorizontalAlignment.Right)
            .Add("Status", 100)
        End With
    End Sub

    Public Sub IsiList()
        Try
            Query = "SELECT tblMasterPeriode.Periode, tblMasterPeriode.DariTgl, tblMasterPeriode.SampaiTgl, tblMasterPeriode.Keterangan FROM(tblMasterPeriode) WHERE ((Left([Periode],4)= '" & cboPeriode.Text & "')) ORDER BY tblMasterPeriode.Periode"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(1), "dd/MM/yyyy"))
                    .Items(a).SubItems.Add(Format(dsData.Tables(0).Rows(a).Item(2), "dd/MM/yyyy"))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.Transparent
                    Else
                        .Items(a).BackColor = Color.White
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AmbilData()
        Try
            With ListView.SelectedItems
                cboPeriode.Text = .Item(0).SubItems(0).Text
                txtTglDari.Text = .Item(0).SubItems(1).Text
                txtTglSampai.Text = .Item(0).SubItems(2).Text
                mPosted = .Item(0).SubItems(3).Text
            End With
        Catch ex As Exception
        End Try
    End Sub

    Public Sub IsiPeriode()
        Try
            Query = "SELECT DISTINCT Left([Periode],4) AS mPeriode FROM(tblMasterPeriode) GROUP BY Left([Periode],4), tblMasterPeriode.Periode ORDER BY Left([Periode],4) DESC"
            daData = New OleDbDataAdapter(Query, CONN)
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

    Public Sub BersihkanIsian()
        cboPeriode.Text = Format(Now.Year)
        txtTglDari.Text = Now
        txtTglSampai.Text = Now
        cboPeriode.Focus()
    End Sub

    Public Function SimpanData()
        Try
            Query = "INSERT INTO tblMasterPeriode VALUES('" & cboPeriode.Text & "', '" & txtTglDari.Text & "' , '" & txtTglSampai.Text & "', '" & "UnPosted" & "')"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)
            IsiList()
            MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information, "")
            Return Query
        Catch ex As Exception
            MsgBox("Data tidak bisa tersimpan karena periode ini sudah ada...", MsgBoxStyle.Exclamation, "Error")
            cboPeriode.Focus()
            Return Query
        End Try
    End Function

    Public Function HapusData()
        Try
            Query = "DELETE FROM tblMasterPeriode WHERE Periode = '" & cboPeriode.Text & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
            IsiList()
            MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "")
            Return Query
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub frmMasterPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiKeAccess()
            KondisiAwal()
            IsiPeriode()
            PosisiList()
            IsiList()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        Buka()
        BersihkanIsian()
        IsiList()
        cboPeriode.Focus()
        cmdEdit.Enabled = False
        cmdHapus.Enabled = False
        cmdSimpan.Enabled = True
        cmdKeluar.Text = "Batal"
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
            Try
                If cboPeriode.Text = "" Or Len(cboPeriode.Text) < 6 Then
                    MessageBox.Show("Periode tidak boleh kosong atau digit periode kurang dari 6", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cboPeriode.Focus()
                Else
                    If mPosted = "Posted" Then
                        MsgBox("Periode ini sudah diposting, tidak bisa di simpan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                        KondisiAwal()
                        cboPeriode.Enabled = True
                        cboPeriode.Focus()
                    Else
                        SimpanData()
                        KondisiAwal()
                        IsiList()
                        cboPeriode.Focus()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Data sudah disimpan.....", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
            End Try
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Buka()
        If mPosted = "Posted" Then
            MsgBox("Periode ini sudah diPosting, tidak bisa diEdit", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Pesan")
            KondisiAwal()
        Else
            Try
                Buka()
                If cmdEdit.Text = "Edit" Then
                    cmdEdit.Text = "Update"
                    cmdTambah.Enabled = False
                    cmdSimpan.Enabled = False
                    cmdHapus.Enabled = False
                    cmdKeluar.Text = "Batal"
                    cboPeriode.Enabled = False
                    cboPeriode.Focus()
                ElseIf cboPeriode.Text = "" Or txtTglDari.Text = "" Or txtTglSampai.Text = "" Then
                    MsgBox("Pastikan Data diisi Lengkap!", MsgBoxStyle.Information, "")
                Else
                    KoneksiKeAccess()
                    Dim EditData As String = "Update tblMasterPeriode set DariTgl = '" & txtTglDari.Text & "', SampaiTgl = '" & txtTglSampai.Text & "' WHERE Periode = '" & cboPeriode.Text & "'"
                    Command = New OleDbCommand(EditData, CONN)
                    Command.ExecuteNonQuery()
                    MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "")
                    KondisiAwal()
                    IsiList()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
            Try
                If Len(cboPeriode.Text) = 0 Then
                    MsgBox("Pilih data yang dihapus", MsgBoxStyle.Information, "Perhatian")
                    cboPeriode.Focus()
                    Exit Sub
                Else
                    Dim A As String

                A = MsgBox("Anda Yakin Ingin Menghapus?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Informasi")
                    Select Case A
                        Case vbCancel
                            cboPeriode.Focus()
                            Exit Sub
                        Case vbOK
                        If mPosted = "Posted" Then
                            MsgBox("Periode ini sudah diposting, Tidak bisa diHapus!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                            KondisiAwal()
                        Else
                            HapusData()
                            KondisiAwal()
                            IsiList()
                            cboPeriode.Focus()
                        End If
                    End Select
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
            End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        If cmdKeluar.Text = "Batal" Then
            KondisiAwal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cboPeriode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPeriode.KeyPress
        If e.KeyChar = Chr(13) Then
            If cboPeriode.Text = "" Then
                MsgBox("Periode masih kosong, silahkan diisi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                cboPeriode.Focus()
            Else
                txtTglDari.Focus()
            End If
        End If
    End Sub

    Private Sub cboPeriode_KeyUp(sender As Object, e As KeyEventArgs) Handles cboPeriode.KeyUp
        If e.KeyCode = Keys.Escape Then
            BersihkanIsian()
        End If
    End Sub

    Private Sub cboPeriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriode.SelectedIndexChanged
        IsiList()
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        AmbilData()
        cboPeriode.Enabled = False
        cmdTambah.Enabled = False
        cmdSimpan.Enabled = False
        cmdHapus.Enabled = True
        cmdEdit.Enabled = True
        cmdKeluar.Text = "Batal"
    End Sub

    Private Sub ListView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListView.KeyPress
        If e.KeyChar = Chr(13) Then
            AmbilData()
            cboPeriode.Enabled = False
        End If
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged
        AmbilData()
        cboPeriode.Enabled = False
    End Sub
End Class