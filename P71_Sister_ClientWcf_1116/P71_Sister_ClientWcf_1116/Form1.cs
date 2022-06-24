using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P71_Sister_ClientWcf_1116
{
    public partial class Form1 : Form
    {
        wcfService.CalculatorClient myService;
        double hasil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myService = new wcfService.CalculatorClient();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            hasil = myService.tambah(int.Parse(etA.Text), int.Parse(etB.Text));
            etHasil.Text = hasil.ToString();
        }

        private void btKurang_Click(object sender, EventArgs e)
        {
            hasil = myService.kurang(int.Parse(etA.Text), int.Parse(etB.Text));
            etHasil.Text = hasil.ToString();
        }

        private void btKali_Click(object sender, EventArgs e)
        {
            hasil = myService.kali(int.Parse(etA.Text), int.Parse(etB.Text));
            etHasil.Text = hasil.ToString();
        }

        private void btBagi_Click(object sender, EventArgs e)
        {
            hasil = myService.bagi(int.Parse(etA.Text), int.Parse(etB.Text));
            etHasil.Text = hasil.ToString();
        }
    }
}
