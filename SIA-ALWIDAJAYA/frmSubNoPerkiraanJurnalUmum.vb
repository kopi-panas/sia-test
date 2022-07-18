Imports System.Data.OleDb
Public Class frmSubNoPerkiraanJurnalUmum

    Private Sub PosisiList()
        With ListView.Columns
            .Add("No.Perkiraan", 100)
            .Add("Nama Perkiraan", 405)
        End With
    End Sub

    Private Sub IsiList()
        Try
            Query = "SELECT * FROM tblMasterPerkiraan ORDER BY NoPerkiraan"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            ListView.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
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
                frmJurnalUmum.txtNoPerkiraan.Text = .Item(0).SubItems(0).Text
                frmJurnalUmum.lblNamaPerkiraan.Text = .Item(0).SubItems(1).Text
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormSubAkunJurnalUmum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiKeAccess()
            PosisiList()
            IsiList()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub ListView_DoubleClick(sender As Object, e As EventArgs) Handles ListView.DoubleClick
        AmbilData()
        Me.Close()
    End Sub

    Private Sub ListView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListView.KeyPress
        If e.KeyChar = Chr(13) Then
            AmbilData()
            Me.Close()
        End If
    End Sub

    Private Sub cmdYa_Click(sender As Object, e As EventArgs) Handles cmdYa.Click
        AmbilData()
        Me.Close()
    End Sub
End Class