Imports System.Data.OleDb
Public Class frmPosting

    Private Sub frmPosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KoneksiKeAccess()
            isicboPeriode()
        Catch ex As Exception
            MsgBox("Koneksi ke database gagal")
        End Try
    End Sub

    'Memposting data dari jurnal umum, ajp dan saldo bulan lalu
    Private Sub cmdPosting_Click(sender As Object, e As EventArgs) Handles cmdPosting.Click
        Dim objPosting As New clsPosting

        Dim mKeterangan As String

        If cboPeriode.Text = "" Then
            MsgBox("Silahkan pilih periode yang diposting", vbExclamation + MsgBoxStyle.OkOnly, "Pesan")
            cboPeriode.Focus()
        Else
            Query = "SELECT Periode, Keterangan FROM tblMasterPeriode WHERE Periode = '" & cboPeriode.Text & "'"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                mKeterangan = 0
            Else
                mKeterangan = dsData.Tables(0).Rows(0).Item(1)
            End If

            If mKeterangan = "UnPosted" Then
                With objPosting
                    .InsertBukuBesar()
                    .InsertBukuBesarAJP()
                    .InsertNeracaSaldo()
                    .InsertNeracaSaldoAJP()
                    .InsertNeracaLajur()
                    .InsertRugiLaba()
                    .PerubahanModal()
                    .UpdatePrive()
                    .NilaiNeraca()
                    .NilaiNeracaAkumulasi()
                    .UpdateModal()
                    .InsertLabaTakDibagi()
                    .UpDateSaldoAwal()
                    .SaldoBulanLalu()
                    .InsertBukuBesarTotal()
                    .InsertKeteranganSaldoAwal() 'Menerangkan bahwa setup saldo awal sudah diPosted
                    MsgBox("Proses posting sudah selesai!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan proses posting")
                End With
            Else
                MsgBox("Periode ini sudah diposting!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Pesan proses posting")
            End If
        End If
    End Sub

    Private Sub isicboPeriode()
        Try
            Query = "SELECT tblMasterPeriode.Periode, tblMasterPeriode.Keterangan FROM tblMasterPeriode WHERE (((tblMasterPeriode.Keterangan)= '" & "UnPosted" & "')) ORDER BY tblMasterPeriode.Periode"
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

    Private Sub MembuatPeriodeBerikutnya()
        Try
            If Microsoft.VisualBasic.Right(cboPeriode.Text, 2) = "12" Then
                lblPeriodeBerikutnya.Text = Microsoft.VisualBasic.Left(cboPeriode.Text, 4) + 1 & "01"
            Else
                lblPeriodeBerikutnya.Text = cboPeriode.Text + 1
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdKeluar_Click(sender As Object, e As EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub cboPeriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriode.SelectedIndexChanged
        MembuatPeriodeBerikutnya()
    End Sub
End Class