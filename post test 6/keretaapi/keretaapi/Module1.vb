Imports MySql.Data.MySqlClient

Module ModulKoneksi
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public rd As MySqlDataReader
    Public cmd As MySqlCommand

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_kereta")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
