Imports System.Data.OleDb
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtkode.Text = "ADM001"
        txtSandi.Text = "admin"
        txtkode.Focus()
    End Sub

    Private Sub cmdMasuk_Click(sender As Object, e As EventArgs) Handles cmdMasuk.Click
        Try
            If txtkode.Text = "" Or txtSandi.Text = "" Then
                MsgBox("Silahkan Masukkan Nama Pengguna dan Kata Sandi!", MsgBoxStyle.Information, "")
            Else
                KoneksiKeAccess()
                Command = New OleDbCommand("select * from tblMasterUser where KodeUser = '" & txtkode.Text & "' and KataKunci ='" & txtSandi.Text & "'", CONN)
                Rd = Command.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Me.Hide()
                    FormMenuUtama.Show()
                    'FormMenuUtama.txtName.Text = Rd.Item("NamaUser")
                Else
                    MsgBox("Kode Admin atau Password Salah!", MsgBoxStyle.Information, "")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSandi.Focus()
        End If
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        FormMenuUtama.Close()
        Me.Close()
    End Sub
End Class