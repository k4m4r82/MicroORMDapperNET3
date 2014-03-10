using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using Dapper;

namespace SiswaDapperNET3
{
    class Program
    {

        private static SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;

            //try
            //{
                var appDir = System.IO.Directory.GetCurrentDirectory();
                var strConn = "Data Source=" + appDir + "\\siswa.sqlite";

                conn = new SQLiteConnection(strConn);
                conn.Open();
            //}
            //catch (Exception)
            //{
            //}

            return conn;
        }

        static void Main(string[] args)
        {
            var strSql = string.Empty;
            var result = 0;

            // INSERT

            // Wicaksono

            //var siswa = new Siswa
            //{
            //    Nis = "9991", Nama = "Bagus"
            //};

            // Misal untuk nama parameternya kita set @NomorInduk dan @NamaSiswa.

            //using (var conn = GetOpenConnection())
            //{
            //    strSql = "INSERT INTO siswa (nis, nama) VALUES (@Nis, @Nama)";
            //    result = conn.Execute(strSql, siswa);
            //}

            using (var conn = GetOpenConnection())
            {
                strSql = "INSERT INTO siswa (nis, nama) VALUES (@Nis, @Nama)";
                result = conn.Execute(strSql, siswa);
            }

            // UPDATE
            //var siswa = new Siswa
            //{
            //    Nis = "9991",
            //    Nama = "Bagus Wicaksono"
            //};

            //using (var conn = GetOpenConnection())
            //{
            //    strSql = "UPDATE siswa SET nama = @Nama WHERE nis = @Nis";
            //    result = conn.Execute(strSql, siswa);
            //}

            // DELETE
            //var siswa = new Siswa
            //{
            //    Nis = "9991"
            //};

            //using (var conn = GetOpenConnection())
            //{
            //    strSql = "DELETE FROM siswa WHERE nis = @Nis";
            //    result = conn.Execute(strSql, siswa);
            //}

            //using (var conn = GetOpenConnection())
            //{
            //    strSql = "SELECT * FROM siswa";
            //    var daftarSiswa = conn.Query<Siswa>(strSql, null);
            //    foreach (var siswa in daftarSiswa)
            //    {
            //        Console.WriteLine(siswa.Nis + ", " + siswa.Nama);
            //    }
            //}

            //Console.WriteLine("result : " + result);
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
