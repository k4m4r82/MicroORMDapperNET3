Imports System.Data.SQLite
Imports Dapper

Module Module1

    Private Function GetOpenConnection() As SQLiteConnection
        Dim conn As SQLiteConnection = Nothing

        Dim appDir As String = System.IO.Directory.GetCurrentDirectory()
        Dim strConn As String = "Data Source=" + appDir + "\siswa.sqlite"

        'Try

        conn = New SQLiteConnection(strConn)
        conn.Open()

        'Catch ex As Exception

        'End Try

        Return conn
    End Function

    Sub Main()
        'Dim daftarSiswa = New List(Of Siswa)()
        'Using conn As OleDbConnection = GetOpenConnection()
        '    Dim strSql = "SELECT nis, nama FROM siswa"
        '    daftarSiswa = conn.Query(Of Siswa)(strSql, Nothing).ToList()
        'End Using

        Dim strSql As String = String.Empty
        Dim result As Integer = 0

        ' INSERT
        Dim siswa As New Siswa() With {.Nis = "9991", .Nama = "Bagus"}

        Using conn As SQLiteConnection = GetOpenConnection()
            strSql = "INSERT INTO siswa (nis, nama) VALUES (@Nis, @Nama)"
            result = conn.Execute(strSql, siswa)
        End Using

        Console.WriteLine("result : " & result)
        Console.ReadKey()
    End Sub

End Module
