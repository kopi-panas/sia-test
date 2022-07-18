Imports System.Data.OleDb
Module Koneksi
    Public CONN As OleDbConnection
    Public daData As OleDbDataAdapter
    Public dsData As DataSet
    Public Command As OleDbCommand
    Public Rd As OleDbDataReader
    Public Query As String

    Public daDataDebetKredit As OleDbDataAdapter
    Public dsDataDebetKredit As DataSet
    Public QueryDebetKredit As String

    Public LokasiData As String

    Public Sub KoneksiKeAccess()
        LokasiData = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_akuntansia.accdb;"
        CONN = New OleDbConnection(LokasiData)
        'CONN.Open()
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub

End Module
