using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_Sister_1116_Exercise2_ClientForm
{
    public partial class Form1 : Form
    {
        Service.WarnaService MyService;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyService = new Service.WarnaService();
        }

        private void btProses_Click(object sender, EventArgs e)
        {
            etWarna.Text = MyService.Warna(int.Parse(etNo.Text));
        }
    }
}
