using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Sister_1116
{
    public partial class halamanDepan : Form
    {
        public halamanDepan()
        {
            InitializeComponent();
        }

        private void btChatApp_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(this);
        }

        private void btSerialCommunication_Click(object sender, EventArgs e)
        {
            serialCommunication form = new serialCommunication();
            form.Show(this);
        }
    }
}
