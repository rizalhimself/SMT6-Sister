using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P51_Sister_1116
{
    public partial class Form1 : Form
    {
        LayananKonversi.WebService1 MyService;
        double CtoR, CtoF, CtoK;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyService = new LayananKonversi.WebService1();
        }

        private void btKonversi_Click(object sender, EventArgs e)
        {
            CtoR = MyService.CelciusToReamur(int.Parse(etCelcius.Text));
            CtoF = MyService.CelciusToFahrenheit(int.Parse(etCelcius.Text));
            CtoK = MyService.CelciusToKelvin(int.Parse(etCelcius.Text));

            etReamur.Text = CtoR.ToString() + " R";
            etFahrenheit.Text = CtoF.ToString() + " F";
            etKelvin.Text = CtoK.ToString() + " K";
        }
    }
}
