using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P72_Sister_WcfDbase_1116.Entity
{
    public class Pegawai
    {
        string nip, nama, jenis_kelamin, alamat, namaJabatan;
        public string NIP 
        {
            get { return nip; }
            set { nip = value; }
        }

        public string NAMA 
        {
            get { return nama; }
            set { nama = value;}
        }
        public string JENIS_KELAMIN 
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }
        public string ALAMAT 
        {
            get { return alamat; }
            set { alamat = value; }
        }
        public string NAMA_JABATAN 
        {
            get { return namaJabatan; }
            set { namaJabatan = value; }
        }
    }
}