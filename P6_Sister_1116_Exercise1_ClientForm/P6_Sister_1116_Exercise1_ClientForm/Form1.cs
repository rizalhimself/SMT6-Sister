using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_Sister_1116_Exercise1_ClientForm
{
    public partial class Form1 : Form
    {
        LayananKonversi.NilaiService MyService;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyService = new LayananKonversi.NilaiService();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            etPredikat.Text = MyService.nilai(int.Parse(etAngka.Text));
        }
    }
}
