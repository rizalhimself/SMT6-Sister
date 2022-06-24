using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace P72_Sister_WcfDbase_1116
{
    public class Koneksi
    {
        static string conn;
        public static MySqlConnection Conn
        {
            get
            {
                return new MySqlConnection(conn);
            }
        }
        static Koneksi()
        {
            string connStr = "Server=192.168.56.1;Uid=rizalhimself;Pwd=16111992;Database=dbAppPegawai";

            conn = connStr;
        }
    }
}