namespace P6_Sister_1116_Exercise2_ClientForm
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
            this.etNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btProses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.etWarna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // etNo
            // 
            this.etNo.Location = new System.Drawing.Point(122, 15);
            this.etNo.Name = "etNo";
            this.etNo.Size = new System.Drawing.Size(93, 20);
            this.etNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nomor Urut";
            // 
            // btProses
            // 
            this.btProses.Location = new System.Drawing.Point(21, 52);
            this.btProses.Name = "btProses";
            this.btProses.Size = new System.Drawing.Size(194, 23);
            this.btProses.TabIndex = 2;
            this.btProses.Text = "Proses";
            this.btProses.UseVisualStyleBackColor = true;
            this.btProses.Click += new System.EventHandler(this.btProses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Warna";
            // 
            // etWarna
            // 
            this.etWarna.Location = new System.Drawing.Point(75, 92);
            this.etWarna.Name = "etWarna";
            this.etWarna.Size = new System.Drawing.Size(140, 20);
            this.etWarna.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etWarna);
            this.Controls.Add(this.btProses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etNo);
            this.Name = "Form1";
            this.Text = "Warna Pelangi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox etNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etWarna;
    }
}

