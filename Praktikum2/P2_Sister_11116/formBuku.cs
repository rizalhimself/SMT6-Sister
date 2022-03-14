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
    public partial class formBuku : Form
    {
        public formBuku()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            formHome frmHome = new formHome();
            frmHome.Show();
            this.Close();
        }
    }
}
