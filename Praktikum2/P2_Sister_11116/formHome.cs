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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void dataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBuku frmBk = new formBuku();
            frmBk.Show();
            this.Hide();
        }

        private void dataPeminjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPeminjam frmPj = new formPeminjam();
            frmPj.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
