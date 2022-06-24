using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace P72_Sister_WcfDbase_1116
{
    public class Fungsi
    {
        static MySqlConnection conn;
        static MySqlDataAdapter sdaUser;
        static DataSet dsUser;

        public static DataSet dataGrid(string query, string tabel)
        {
            conn = Koneksi.Conn;
            sdaUser = new MySqlDataAdapter(query, conn);
            dsUser = new DataSet();
            try
            {
                conn.Open();
                sdaUser.Fill(dsUser, tabel);
                return dsUser;
            }
            catch (MySqlException ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}