
namespace P3_Sister_1116
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.etServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.etServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.etClientPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.etIPClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btStartServer = new System.Windows.Forms.Button();
            this.btClientConnect = new System.Windows.Forms.Button();
            this.etChat = new System.Windows.Forms.TextBox();
            this.etPesan = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.etServerPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.etServerIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // etServerPort
            // 
            this.etServerPort.Location = new System.Drawing.Point(61, 55);
            this.etServerPort.Name = "etServerPort";
            this.etServerPort.Size = new System.Drawing.Size(100, 20);
            this.etServerPort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // etServerIP
            // 
            this.etServerIP.Location = new System.Drawing.Point(61, 29);
            this.etServerIP.Name = "etServerIP";
            this.etServerIP.Size = new System.Drawing.Size(100, 20);
            this.etServerIP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.etClientPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.etIPClient);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // etClientPort
            // 
            this.etClientPort.Location = new System.Drawing.Point(60, 49);
            this.etClientPort.Name = "etClientPort";
            this.etClientPort.Size = new System.Drawing.Size(100, 20);
            this.etClientPort.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            // 
            // etIPClient
            // 
            this.etIPClient.Location = new System.Drawing.Point(60, 23);
            this.etIPClient.Name = "etIPClient";
            this.etIPClient.Size = new System.Drawing.Size(100, 20);
            this.etIPClient.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP";
            // 
            // btStartServer
            // 
            this.btStartServer.Location = new System.Drawing.Point(116, 112);
            this.btStartServer.Name = "btStartServer";
            this.btStartServer.Size = new System.Drawing.Size(75, 23);
            this.btStartServer.TabIndex = 2;
            this.btStartServer.Text = "Start Server";
            this.btStartServer.UseVisualStyleBackColor = true;
            this.btStartServer.Click += new System.EventHandler(this.btStartServer_Click);
            // 
            // btClientConnect
            // 
            this.btClientConnect.Location = new System.Drawing.Point(116, 253);
            this.btClientConnect.Name = "btClientConnect";
            this.btClientConnect.Size = new System.Drawing.Size(75, 23);
            this.btClientConnect.TabIndex = 3;
            this.btClientConnect.Text = "Connect";
            this.btClientConnect.UseVisualStyleBackColor = true;
            this.btClientConnect.Click += new System.EventHandler(this.btClientConnect_Click);
            // 
            // etChat
            // 
            this.etChat.Location = new System.Drawing.Point(213, 14);
            this.etChat.Multiline = true;
            this.etChat.Name = "etChat";
            this.etChat.Size = new System.Drawing.Size(328, 262);
            this.etChat.TabIndex = 4;
            // 
            // etPesan
            // 
            this.etPesan.Location = new System.Drawing.Point(12, 292);
            this.etPesan.Multiline = true;
            this.etPesan.Name = "etPesan";
            this.etPesan.Size = new System.Drawing.Size(429, 35);
            this.etPesan.TabIndex = 5;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(448, 292);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(93, 35);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 339);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.etPesan);
            this.Controls.Add(this.etChat);
            this.Controls.Add(this.btClientConnect);
            this.Controls.Add(this.btStartServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox etServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox etClientPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etIPClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btStartServer;
        private System.Windows.Forms.Button btClientConnect;
        private System.Windows.Forms.TextBox etChat;
        private System.Windows.Forms.TextBox etPesan;
        private System.Windows.Forms.Button btSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

