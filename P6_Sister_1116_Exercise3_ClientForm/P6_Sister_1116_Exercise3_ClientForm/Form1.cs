using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_Sister_1116_Exercise3_ClientForm
{
    public partial class Form1 : Form
    {
        BilanganService.AngkaService myService;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myService = new BilanganService.AngkaService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            etKet.Text = myService.Bilangan(int.Parse(etBilangan.Text));
        }
    }
}
