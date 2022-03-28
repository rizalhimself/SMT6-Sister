using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace P3_Sister_1116
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive, textSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    etIPClient.Text = address.ToString();
                }
            }
        }

        private void btStartServer_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(etServerPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btClientConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(etIPClient.Text), int.Parse(etClientPort.Text));

            try
            {
                client.Connect(iPEnd);
                if (client.Connected)
                {
                    etChat.AppendText("Connected to Server" + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                   
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (etPesan.Text != "")
            {
                textSend = etPesan.Text;
                backgroundWorker2.RunWorkerAsync();

                etPesan.Text = "";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.etChat.Invoke(new MethodInvoker(delegate ()
                    {
                        etChat.AppendText("Anda : " + receive + "\n");
                    }));
                } catch(Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(textSend);
                this.etChat.Invoke(new MethodInvoker(delegate ()
                {
                    etChat.AppendText("Saya : " + textSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Send Failed!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
