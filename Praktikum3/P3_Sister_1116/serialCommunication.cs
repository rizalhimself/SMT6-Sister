using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace P3_Sister_1116
{
    public partial class serialCommunication : Form
    {
        public serialCommunication()
        {
            InitializeComponent();
        }

        private void serialCommunication_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPort.Items.AddRange(ports);
            cboPort.SelectedIndex = 0;
            btClose.Enabled = false;
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            btOpen.Enabled = false;
            btClose.Enabled = true;
            try
            {
                serialPort1.PortName = cboPort.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            btOpen.Enabled = true;
            btClose.Enabled = false;
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messages",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen) ;
                {
                    serialPort1.WriteLine(etSend.Text + Environment.NewLine);
                    etSend.Clear();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReceieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen) ;
                {
                    etReceieve.Text = serialPort1.ReadExisting();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialCommunication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}
