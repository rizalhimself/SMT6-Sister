using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Sister_11116
{
    public partial class formPeminjam : Form
    {
        public formPeminjam()
        {
            InitializeComponent();
            aktifkanTextbox(false);
            totalRecord();
        }

        const int kapasitasAwal = 50;
        string[] arrPeminjam = new string[kapasitasAwal];
        int jmlMax = kapasitasAwal;
        int idx = -1;
        int jmlPeminjam = 0;
        char pemisah = ',';

        private void pisahDataPeminjam(string peminjam)
        {
            char[] pisah = { pemisah };
            string[] dataPeminjam = peminjam.Split(pisah);
            etIdPeminjam.Text = dataPeminjam[0];
            etNamaPeminjam.Text = dataPeminjam[1];
            etAlamat.Text = dataPeminjam[2];
            etNoTelfon.Text = dataPeminjam[3];
        }

        private void aktifkanTextbox(bool sifatKeaktifan)
        {
            etIdPeminjam.Enabled = sifatKeaktifan;
            etNamaPeminjam.Enabled = sifatKeaktifan;
            etAlamat.Enabled = sifatKeaktifan;
            etNoTelfon.Enabled = sifatKeaktifan;
        }

        private void bersih()
        {
            etNamaPeminjam.Clear();
            etIdPeminjam.Clear();
            etAlamat.Clear();
            etNoTelfon.Clear();
        }

        private void totalRecord()
        {
            lbTotRec.Text = "Total Record = " + jmlPeminjam.ToString();
        }

        private void updateDataArray()
        {
            if (jmlPeminjam > 0)
            {
                string peminjam = "";
                peminjam = peminjam + etIdPeminjam.Text + pemisah;
                peminjam = peminjam + etNamaPeminjam.Text + pemisah;
                peminjam = peminjam + etAlamat.Text + pemisah;
                peminjam = peminjam + etNoTelfon.Text;

                arrPeminjam[idx] = peminjam;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            formHome frmHome = new formHome();
            frmHome.Show();
            this.Close();
        }
    }
}
