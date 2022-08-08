Imports System.Data.OleDb
Public Class clsPosting

    Private mPrive As Long
    Private mModal As Long
    Private mPeriode As String
    Private mPerubahanModal As Long
    Private mLabaRugi As Long
    Private mPeriodeBerikutnya As String

    'Memasukkan data saldo awal & saldo bulan lalu
    Public Sub InsertSaldoBulanlalu()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "INSERT INTO BukuBesar SELECT tmpSaldoBlnLalu.Periode, '" & "SBL-" & "' & [Periode] AS NoTransaksi, tmpSaldoBlnLalu.TglTransaksi, tmpSaldoBlnLalu.NoPerkiraan, tmpSaldoBlnLalu.Keterangan, tmpSaldoBlnLalu.DK, tmpSaldoBlnLalu.Debet, tmpSaldoBlnLalu.Kredit, tmpSaldoBlnLalu.Status FROM(tmpSaldoBlnLalu) WHERE(((tmpSaldoBlnLalu.Periode) = '" & mPeriode & "') And ((tmpSaldoBlnLalu.Status) = '" & "UnPosted" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Memasukkan data ke buku besar
    Public Sub InsertBukuBesar()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "SELECT DISTINCT hJurnal.Periode, hJurnal.Status FROM hJurnal WHERE (((hJurnal.Periode)='" & mPeriode & "') AND ((hJurnal.Status)='" & "UnPosted" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                InsertSaldoBulanlalu()
            Else
                InsertSaldoBulanlalu()
                Query = "INSERT INTO BukuBesar SELECT hJurnal.Periode, hJurnal.NoTransaksi, hJurnal.TglTransaksi, dJurnal.NoPerkiraan, hJurnal.Keterangan, dJurnal.DK, dJurnal.Debet, dJurnal.Kredit, hJurnal.Status FROM (dJurnal LEFT JOIN hJurnal ON dJurnal.NoTransaksi = hJurnal.NoTransaksi) LEFT JOIN tblMasterPerkiraan ON dJurnal.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE (((hJurnal.Periode)='" & mPeriode & "') AND ((hJurnal.Status)= '" & "UnPosted" & "'))"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Memasukkan data ke buku besar AJP
    Public Sub InsertBukuBesarAJP()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "INSERT INTO BukuBesarAJP SELECT hJurnalAJP.Periode, hJurnalAJP.NoTransaksi, hJurnalAJP.TglTransaksi, dJurnalAJP.NoPerkiraan, hJurnalAJP.Keterangan, dJurnalAJP.DK, dJurnalAJP.Debet, dJurnalAJP.Kredit, hJurnalAJP.Status FROM (dJurnalAJP LEFT JOIN hJurnalAJP ON dJurnalAJP.NoTransaksi = hJurnalAJP.NoTransaksi) LEFT JOIN tblMasterPerkiraan ON dJurnalAJP.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE (((hJurnalAJP.Periode) = '" & mPeriode & "') AND ((hJurnalAJP.Status)= '" & "UnPosted" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Memasukkan saldo-saldo dari buku besar ke neraca saldo
    Public Sub InsertNeracaSaldo()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "INSERT INTO NeracaSaldo SELECT BukuBesar.Periode, BukuBesar.NoPerkiraan, Sum(BukuBesar.Debet) AS TotalDebet, Sum(BukuBesar.Kredit) AS TotalKredit, IIf([TotalDebet]>[TotalKredit],[TotalDebet]-[TotalKredit],0) AS Saldodebet, IIf([TotalKredit]>[TotalDebet],[TotalKredit]-[TotalDebet],0) AS SaldoKredit FROM(BukuBesar) GROUP BY BukuBesar.Periode, BukuBesar.NoPerkiraan HAVING(((BukuBesar.Periode) = '" & mPeriode & "')) ORDER BY BukuBesar.NoPerkiraan"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Masukkan saldo-saldo dari buku besar AJP ke neraca saldo AJP
    Public Sub InsertNeracaSaldoAJP()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "INSERT INTO tblAJP SELECT BukuBesarAJP.Periode, BukuBesarAJP.NoPerkiraan, Sum(BukuBesarAJP.Debet) AS TotalDebet, Sum(BukuBesarAJP.Kredit) AS TotalKredit, IIf([TotalDebet]>[TotalKredit],[TotalDebet]-[TotalKredit],0) AS mSaldoDebet, IIf([TotalKredit]>[TotalDebet],[TotalKredit]-[TotalDebet],0) AS mSaldoKredit FROM(BukuBesarAJP) GROUP BY BukuBesarAJP.Periode, BukuBesarAJP.NoPerkiraan HAVING(((BukuBesarAJP.Periode) = '" & mPeriode & "')) ORDER BY BukuBesarAJP.NoPerkiraan"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Neraca Lajur
    Public Sub InsertNeracaLajur()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "INSERT INTO NeracaLajur SELECT NeracaSaldo.Periode, NeracaSaldo.NoPerkiraan, NeracaSaldo.SaldoDebet AS DebetNS, NeracaSaldo.SaldoKredit AS KreditNS, IIf([tblAJP].[TotalDebet]>0,[tblAJP].[TotalDebet],0) AS DebetAJP, IIf([tblAJP].[TotalKredit]>0,[tblAJP].[TotalKredit],0) AS KreditAJP, IIf(([DebetNS]+[DebetAJP])-[KreditAJP]>0,(([DebetNS]+[DebetAJP])-([KreditNS]+[KreditAJP])),0) AS DebetNSD, IIf(([KreditNS]+[KreditAJP])-[DebetNS]+[DebetAJP]>0,(([KreditNS]+[KreditAJP])-([DebetNS]+[DebetAJP])),0) AS KreditNSD, IIf(Left(NeracaSaldo.NoPerkiraan,1)= '" & "4" & "' Or Left(NeracaSaldo.NoPerkiraan,1)= '" & "5" & "',[DebetNSD],0) AS DebetRL, IIf(Left(NeracaSaldo.NoPerkiraan,1)= '" & "4" & "' Or Left(NeracaSaldo.NoPerkiraan,1)= '" & "5" & "',[KreditNSD],0) AS KreditRL, IIf(Left([NeracaSaldo].[NoPerkiraan],1)= '" & "1" & "' Or Left([NeracaSaldo].[NoPerkiraan],1)= '" & "2" & "' Or Left([NeracaSaldo].[NoPerkiraan],1)= '" & "3" & "',[DebetNSD],0) AS DebetNeraca, IIf(Left([NeracaSaldo].[NoPerkiraan],1)= '" & "1" & "' Or Left([NeracaSaldo].[NoPerkiraan],1)= '" & "2" & "' Or Left([NeracaSaldo].[NoPerkiraan],1)= '" & "3" & "',[KreditNSD],0) AS KreditNeraca FROM (NeracaSaldo LEFT JOIN tblMasterPerkiraan ON NeracaSaldo.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan) LEFT JOIN tblAJP ON tblMasterPerkiraan.NoPerkiraan = tblAJP.NoPerkiraan WHERE(((NeracaSaldo.Periode) = '" & mPeriode & "')) ORDER BY NeracaSaldo.NoPerkiraan"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Laporan Rugi/Laba
    Public Sub InsertRugiLaba()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            'Periksa data rugi / laba ada apa tidak
            Query = "SELECT NeracaLajur.Periode, NeracaLajur.NoPerkiraan, IIf(Left(NeracaLajur.NoPerkiraan,1)= '" & "4" & "','" & "Pendapatan" & "',IIf(Left(NeracaLajur.NoPerkiraan,1)= '" & "5" & "','" & "Harga Pokok Penjualan" & "',IIf(Left(NeracaLajur.NoPerkiraan,1)='" & "6" & "','" & "Biaya-Biaya" & "','" & " " & "')) AS Keterangan, NeracaLajur.DebetRL AS Debet, NeracaLajur.KreditRL AS Kredit FROM NeracaLajur LEFT JOIN tblMasterPerkiraan ON NeracaLajur.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE(((NeracaLajur.Periode) ='" & mPeriode & "') And ((NeracaLajur.NoPerkiraan) Like '" & "4" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "5" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "6" & "%" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                Query = "INSERT INTO tblRugiLaba Values('" & mPeriode & "', '" & "41001" & "' , '" & "Pendapatan" & "', '" & 0 & "', '" & 0 & "')"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)

                Query = "INSERT INTO tblRugiLaba Values('" & mPeriode & "', '" & "51001" & "' , '" & "Harga Pokok Penjualan" & "', '" & 0 & "', '" & 0 & "')"
                daData = New OleDbDataAdapter(Query, CONN)
                dsData = New DataSet
                daData.Fill(dsData)

                Query = "INSERT INTO tblRugiLaba Values('" & mPeriode & "', '" & "61001" & "' , '" & "Biaya-Biaya" & "', '" & 0 & "', '" & 0 & "')"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)
            Else
                Query = "INSERT INTO tblRugiLaba SELECT NeracaLajur.Periode, NeracaLajur.NoPerkiraan, IIf(Left(NeracaLajur.NoPerkiraan,1)= '" & "4" & "','" & "Pendapatan" & "',IIf(Left(NeracaLajur.NoPerkiraan,1)= '" & "5" & "','" & "Harga Pokok Penjualan" & "',IIf(Left(NeracaLajur.NoPerkiraan,1)='" & "6" & "','" & "Biaya-Biaya" & "','" & " " & "')) AS Keterangan, NeracaLajur.DebetRL AS Debet, NeracaLajur.KreditRL AS Kredit FROM NeracaLajur LEFT JOIN tblMasterPerkiraan ON NeracaLajur.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE(((NeracaLajur.Periode) ='" & mPeriode & "') And ((NeracaLajur.NoPerkiraan) Like '" & "4" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "5" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "6" & "%" & "'))"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Perubahan Modal
    Public Sub PerubahanModal()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "SELECT NeracaLajur.Periode, NeracaLajur.NoPerkiraan, IIf(Left(NeracaLajur.NoPerkiraan,1)='" & "4" & "','" & "Pendapatan" & "',IIf(Left(NeracaLajur.NoPerkiraan,1)= '" & "6" & "','" & "Biaya-Biaya" & "','" & "" & "')) AS Keterangan, NeracaLajur.DebetRL AS Debet, NeracaLajur.KreditRL AS Kredit FROM NeracaLajur LEFT JOIN tblMasterPerkiraan ON NeracaLajur.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan WHERE(((NeracaLajur.Periode) = '" & mPeriode & "') And ((NeracaLajur.NoPerkiraan) Like '" & "4" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "6" & "%" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                mPeriode = frmPosting.cboPeriode.Text
                mLabaRugi = 0
                Query = "INSERT INTO tblPerubahanModal(Periode, LabaBersih) VALUES('" & mPeriode & "','" & mLabaRugi & "')"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)
            Else
                Query = "INSERT INTO tblPerubahanModal SELECT NeracaLajur.Periode, Sum([KreditRL])-Sum([DebetRL]) AS LabaBersih FROM NeracaLajur LEFT JOIN tblMasterPerkiraan ON NeracaLajur.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan GROUP BY NeracaLajur.Periode HAVING (((NeracaLajur.Periode)='" & mPeriode & "'))"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Update Prive
    Public Sub UpdatePrive()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "SELECT NeracaLajur.Periode, IIf([DebetNeraca]>0,[DebetNeraca],0) AS Prive FROM NeracaLajur LEFT JOIN tblMasterPerkiraan ON NeracaLajur.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan GROUP BY NeracaLajur.Periode, NeracaLajur.NoPerkiraan, IIf([DebetNeraca]>0,[DebetNeraca],0) HAVING(((NeracaLajur.Periode) = '" & mPeriode & "') And ((NeracaLajur.NoPerkiraan) = '" & "32010" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                mPrive = 0
            Else
                mPrive = dsData.Tables(0).Rows(0).Item(1)
            End If
            Query = "UPDATE tblPerubahanModal SET prive = '" & mPrive & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Neraca
    Public Sub NilaiNeraca()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "INSERT INTO tblNeraca SELECT NeracaLajur.Periode, IIf(Left(Neracalajur.NoPerkiraan,1)='" & "1" & "','" & "Aktiva" & "','" & "Pasiva" & "') AS Judul1, IIf(Left(Neracalajur.NoPerkiraan,2)='" & "11" & "','" & "Aktiva Lancar" & "',IIf(Left(Neracalajur.NoPerkiraan,2)='" & "12" & "','" & "Aktiva Tetap" & "',IIf(Left(Neracalajur.NoPerkiraan,1)='" & "2" & "','" & "Hutang" & "',IIf(Left(Neracalajur.NoPerkiraan,1)='" & "3" & "','" & "Modal" & "' ,'" & " " & "')))) AS Judul2, IIf(Left(Neracalajur.NoPerkiraan,2)='" & "11" & "','" & " " & "',IIf(Left(Neracalajur.NoPerkiraan,2)='" & "12" & "','" & " " & "',IIf(Left(Neracalajur.NoPerkiraan,2)='" & "21" & "','" & "Hutang Jangka Pendek" & "',IIf(Left(Neracalajur.NoPerkiraan,2)='" & "22" & "' ,'" & "Hutang Jangka Panjang" & "',IIf(Left(Neracalajur.NoPerkiraan,2)='" & "31" & "','" & "Modal" & "',IIf(Left(Neracalajur.NoPerkiraan,2)='" & "32" & "','" & "Prive" & "','" & " " & "')))))) AS Judul3, NeracaLajur.NoPerkiraan, [DebetNeraca]+[KreditNeraca] AS Nominal, IIf([NoPerkiraan]='" & "32010" & "',-[Nominal],[Nominal]) AS Nilai FROM(NeracaLajur) WHERE (((NeracaLajur.Periode)='" & mPeriode & "') AND ((NeracaLajur.NoPerkiraan) Like '" & "1" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "2" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "3" & "%" & "'))"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Update Nilai Neraca dengan nilai Akumulasi Penyusutan
    Public Sub NilaiNeracaAkumulasi()
        Try
            mPeriode = frmPosting.cboPeriode.Text
            Query = "UPDATE (tblNeraca LEFT JOIN tblMasterPerkiraan ON tblNeraca.NoPerkiraan = tblMasterPerkiraan.NoPerkiraan) LEFT JOIN NeracaLajur ON tblNeraca.NoPerkiraan = NeracaLajur.NoPerkiraan SET tblNeraca.Nominal = -[NeracaLajur].[KreditNSD], tblNeraca.Nilai = -[NeracaLajur].[KreditNSD] WHERE (((tblMasterPerkiraan.Keterangan)='" & "Ya" & "') AND ((tblNeraca.Periode)='" & mPeriode & "'));"
            daData = New OleDbDataAdapter(Query, CONN)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub


    'UpDate Modal di Tabel perubahan modal dari neraca
    Public Sub UpdateModal()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "SELECT DISTINCT tblNeraca.Periode, tblNeraca.NoPerkiraan, tblNeraca.Nominal FROM(tblNeraca) WHERE(((tblNeraca.Periode) = '" & mPeriode & "') And ((tblNeraca.NoPerkiraan) = '" & "31001" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                mModal = 0
            Else
                mModal = dsData.Tables(0).Rows(0).Item(2)
            End If

            Query = "UPDATE tblPerubahanModal SET Modal = '" & mModal & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub


    'Update Laba tidak dibagi ke tabel neraca
    Public Sub InsertLabaTakDibagi()
        mPeriode = frmPosting.cboPeriode.Text
        Dim mNilai As Long
        Dim mLabaBersih As Long

        Try
            'Tanpa saldo awal di master perkiraan
            Query = "SELECT NeracaLajur.Periode, Sum([KreditRL])-Sum([DebetRL]) AS LabaBersih FROM NeracaLajur LEFT JOIN tblMasterPerkiraan ON NeracaLajur.NoPerkiraan=tblMasterPerkiraan.NoPerkiraan GROUP BY NeracaLajur.Periode HAVING (((NeracaLajur.Periode)='" & mPeriode & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                mLabaBersih = 0
            Else
                mLabaBersih = dsData.Tables(0).Rows(0).Item(1)
            End If

            mNilai = mLabaBersih
            Query = "INSERT INTO tblNeraca (Periode, Judul1, Judul2, Judul3, NoPerkiraan, Nominal, Nilai)  VALUES('" & mPeriode & "', '" & "Pasiva" & "' , '" & "Modal" & "', '" & "Rugi/Laba bersih" & "',  '" & "31002" & "', '" & mLabaBersih & "', '" & mNilai & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Update UnPosted menjadi Posted pada tabela saldo awal
    Public Sub UpDateSaldoAwal()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "UPDATE tmpSaldoBlnLalu SET Status = '" & "Posted" & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

    'Insert keterangan pada tabel tblStatusSetUpSaldoAwal
    Public Sub InsertKeteranganSaldoAwal()
        mPeriode = frmPosting.cboPeriode.Text
        Try
            Query = "SELECT *  FROM tblStatusSetupSaldoAwal"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                Query = "INSERT INTO tblStatusSetupSaldoAwal VALUES('" & "Posted" & "')"
                daData = New OleDbDataAdapter(Query, conn)
                dsData = New DataSet
                daData.Fill(dsData)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Mutasi Saldo , menjadi saldo awal di periode berikutnya
    Public Sub SaldoBulanLalu()
        mPeriode = frmPosting.cboPeriode.Text
        mPeriodeBerikutnya = frmPosting.lblPeriodeBerikutnya.Text
        Try
            'Memasukkan saldo bulan lalu
            Query = "INSERT INTO tmpSaldoBlnLalu SELECT NeracaLajur.Periode, tblMasterPeriode.SampaiTgl AS TglTransaksi, NeracaLajur.NoPerkiraan, IIf([DebetNeraca]>[KreditNeraca],'" & "D" & "',IIf([DebetNeraca]=0 And [KreditNeraca]=0,'" & "D" & "','" & "K" & "')) AS DK, NeracaLajur.DebetNeraca AS Debet, NeracaLajur.KreditNeraca AS Kredit, '" & "UnPosted" & "' AS Status, '" & "Saldo bulan lalu" & "' AS Keterangan FROM NeracaLajur LEFT JOIN tblMasterPeriode ON NeracaLajur.Periode = tblMasterPeriode.Periode GROUP BY NeracaLajur.Periode, tblMasterPeriode.SampaiTgl, NeracaLajur.NoPerkiraan, IIf([DebetNeraca]>[KreditNeraca],'" & "D" & "',IIf([DebetNeraca]=0 And [KreditNeraca]=0,'" & "D" & "','" & "K" & "')), NeracaLajur.DebetNeraca, NeracaLajur.KreditNeraca, '" & "UnPosted" & "', '" & "Saldo bulan lalu" & "'  HAVING (((NeracaLajur.Periode)= '" & mPeriode & "') AND ((NeracaLajur.NoPerkiraan) Like '" & "1" & "%" & "' Or (NeracaLajur.NoPerkiraan) Like '" & "2" & "%" & "' Or (NeracaLajur.NoPerkiraan)='" & "31001" & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            'Update periode menjadi periode berikutnya
            Query = "UPDATE tmpSaldoBlnLalu SET Periode = '" & mPeriodeBerikutnya & "' WHERE Periode = '" & mPeriode & "' And Status = '" & "UnPosted" & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            'Mengambil data perubahan modal
            Query = "SELECT tblPerubahanModal.Periode, [Modal]+([LabaBersih]-[Prive]) AS LabaDitahan FROM tblPerubahanModal WHERE (((tblPerubahanModal.Periode)= '" & mPeriode & "'))"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            If dsData.Tables(0).Rows.Count = 0 Then
                mPerubahanModal = 0
            Else
                mPerubahanModal = dsData.Tables(0).Rows(0).Item(1)
            End If

            'Update Modal dengan data perubahan ekuitas
            Query = "UPDATE tmpSaldoBlnLalu SET Kredit = '" & mPerubahanModal & "' WHERE Periode = '" & mPeriodeBerikutnya & "' And Status = '" & "UnPosted" & "' AND NoPerkiraan = '" & "31001" & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            'Buat status dari unposted menjadi posted pada tabel
            'HJurnal, HJurnalAJP, MasterPeriode, BukuBesar, BukuBEsarAJP
            Query = "UPDATE hJurnal SET Status = '" & "Posted" & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            Query = "UPDATE hJurnalAJP SET Status = '" & "Posted" & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            Query = "UPDATE BukuBesar SET Status = '" & "Posted" & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            Query = "UPDATE BukuBesarAJP SET Status = '" & "Posted" & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)

            Query = "UPDATE tblMasterPeriode SET Keterangan = '" & "Posted" & "' WHERE Periode = '" & mPeriode & "'"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
        Catch ex As Exception
        End Try
    End Sub

End Class
