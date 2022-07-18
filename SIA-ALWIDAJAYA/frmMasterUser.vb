Imports System.Data.OleDb
Public Class frmMasterUser

    Sub KondisiAwal()
        cmdTambah.Enabled = True
        cmdEdit.Enabled = False
        cmdSimpan.Enabled = False
        cmdHapus.Enabled = False
        cmdKeluar.Enabled = True
        txtKodeUser.Focus()
        cmdKeluar.Text = "Keluar"
        cmdEdit.Text = "Edit"
        BersihkanIsian()
        Tutup()
    End Sub

    Sub Buka()
        txtKodeUser.Enabled = True
        txtNamaUser.Enabled = True
        txtpassword.Enabled = True
    End Sub

    Sub Tutup()
        txtKodeUser.Enabled = False
        txtNamaUser.Enabled = False
        txtpassword.Enabled = False
    End Sub

    Public Sub PosisiList()
        With ListView.Columns
            .Add("Kode", 80)
            .Add("Nama User", 150)
            .Add("Password", 150)
        End With
    End Sub

    Public Sub IsiList()
        Try
            Query = "SELECT * FROM tblMasterUser ORDER BY KodeUser"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
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

    Private Sub AmbilData()
        Try
            With ListView.SelectedItems
                txtKodeUser.Text = .Item(0).SubItems(0).Text
                txtNamaUser.Text = .Item(0).SubItems(1).Text
                txtpassword.Text = .Item(0).SubItems(2).Text
            End With
        Catch ex As Exception
        End Try
    End Sub

    Public Sub BersihkanIsian()
        txtKodeUser.Clear()
        txtNamaUser.Clear()
        txtpassword.Clear()
        txtKodeUser.Enabled = True
        txtKodeUser.Focus()
    End Sub

    Private Sub frmMasterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KondisiAwal()
            KoneksiKeAccess()
            PosisiList()
            IsiList()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        If cmdKeluar.Text = "Batal" Then
            KondisiAwal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        Try
            If txtKodeUser.Text = "" Or txtNamaUser.Text = "" Or txtpassword.Text = "" Then
                MsgBox("Pastikan Data diisi Lengkap!", MsgBoxStyle.Information, "")
            Else
                KoneksiKeAccess()
                Dim SimpanData As String = "Insert into tblMasterUser values ('" & txtKodeUser.Text & "','" & txtNamaUser.Text & "','" & txtpassword.Text & "')"
                Command = New OleDbCommand(SimpanData, CONN)
                Command.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information, "")
                IsiList()
                KondisiAwal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        Buka()
        Try
            BersihkanIsian()
            IsiList()
            cmdEdit.Enabled = False
            cmdHapus.Enabled = False
            cmdSimpan.Enabled = True
            cmdKeluar.Text = "Batal"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        Try
            Dim ans As String
            ans = MsgBox("Anda Yakin Ingin Menghapus?", MsgBoxStyle.YesNo, "Konfirmasi")
            If ans = vbYes Then
                KoneksiKeAccess()
                Dim HapusData As String = "Delete from tblMasterUser where KodeUser= '" & txtKodeUser.Text & "'"
                Command = New OleDbCommand(HapusData, CONN)
                Command.ExecuteNonQuery()
                MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "")
                IsiList()
                KondisiAwal()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        cmdTambah.Enabled = False
        cmdSimpan.Enabled = False
        cmdHapus.Enabled = True
        cmdEdit.Enabled = True
        cmdKeluar.Text = "Batal"
    End Sub

    Private Sub ListView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListView.KeyPress
        If e.KeyChar = Chr(13) Then
            AmbilData()
            txtKodeUser.Enabled = False
        End If
    End Sub

    Private Sub ListView_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView.KeyUp
        If e.KeyCode = Keys.Escape Then
            BersihkanIsian()
            txtKodeUser.Enabled = True
        End If
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged
        txtKodeUser.Enabled = False
        AmbilData()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Buka()
        Try
            If cmdEdit.Text = "Edit" Then
                cmdEdit.Text = "Update"
                cmdTambah.Enabled = False
                cmdSimpan.Enabled = False
                cmdHapus.Enabled = False
                cmdKeluar.Text = "Batal"
                txtKodeUser.Enabled = False
                txtNamaUser.Focus()
            ElseIf txtKodeUser.Text = "" Or txtNamaUser.Text = "" Or txtpassword.Text = "" Then
                MsgBox("Pastikan Data diisi Lengkap!", MsgBoxStyle.Information, "")
            Else
                KoneksiKeAccess()
                Dim EditData As String = "Update tblMasterUser set NamaUser='" & txtNamaUser.Text & "',KataKunci='" & txtpassword.Text & "' where KodeUser= '" & txtKodeUser.Text & "'"
                Command = New OleDbCommand(EditData, CONN)
                Command.ExecuteNonQuery()
                MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "")
                IsiList()
                KondisiAwal()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtKodeUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeUser.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtKodeUser.Text = "" Then
                MsgBox("Kode user tidak boleh kosong", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                txtKodeUser.Focus()
            Else
                txtNamaUser.Focus()
            End If
        End If
    End Sub

    Private Sub txtNamaUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaUser.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNamaUser.Text = "" Then
                MsgBox("Nama user tidak boleh kosong", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                txtNamaUser.Focus()
            Else
                txtpassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtpassword.Text = "" Then
                MsgBox("Password masih kosong", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Pesan")
                txtpassword.Focus()
            Else
                cmdSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub txtKodeUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtKodeUser.KeyUp
        If e.KeyCode = Keys.Escape Then
            BersihkanIsian()
        End If
    End Sub

End Class