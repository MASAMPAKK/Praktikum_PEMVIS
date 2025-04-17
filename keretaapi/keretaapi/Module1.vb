
Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet

    Public Sub Koneksi()
        Try
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=db_kereta")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module
