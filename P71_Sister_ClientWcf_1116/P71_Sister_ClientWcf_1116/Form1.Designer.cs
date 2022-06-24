namespace P71_Sister_ClientWcf_1116
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
            this.label1 = new System.Windows.Forms.Label();
            this.etA = new System.Windows.Forms.TextBox();
            this.etB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.etHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btTambah = new System.Windows.Forms.Button();
            this.btKurang = new System.Windows.Forms.Button();
            this.btKali = new System.Windows.Forms.Button();
            this.btBagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka A";
            // 
            // etA
            // 
            this.etA.Location = new System.Drawing.Point(89, 22);
            this.etA.Name = "etA";
            this.etA.Size = new System.Drawing.Size(100, 20);
            this.etA.TabIndex = 1;
            // 
            // etB
            // 
            this.etB.Location = new System.Drawing.Point(89, 48);
            this.etB.Name = "etB";
            this.etB.Size = new System.Drawing.Size(100, 20);
            this.etB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angka B";
            // 
            // etHasil
            // 
            this.etHasil.Location = new System.Drawing.Point(89, 74);
            this.etHasil.Name = "etHasil";
            this.etHasil.Size = new System.Drawing.Size(100, 20);
            this.etHasil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil";
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(28, 124);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(69, 29);
            this.btTambah.TabIndex = 6;
            this.btTambah.Text = "+";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btKurang
            // 
            this.btKurang.Location = new System.Drawing.Point(120, 124);
            this.btKurang.Name = "btKurang";
            this.btKurang.Size = new System.Drawing.Size(69, 29);
            this.btKurang.TabIndex = 7;
            this.btKurang.Text = "-";
            this.btKurang.UseVisualStyleBackColor = true;
            this.btKurang.Click += new System.EventHandler(this.btKurang_Click);
            // 
            // btKali
            // 
            this.btKali.Location = new System.Drawing.Point(28, 174);
            this.btKali.Name = "btKali";
            this.btKali.Size = new System.Drawing.Size(69, 29);
            this.btKali.TabIndex = 8;
            this.btKali.Text = "x";
            this.btKali.UseVisualStyleBackColor = true;
            this.btKali.Click += new System.EventHandler(this.btKali_Click);
            // 
            // btBagi
            // 
            this.btBagi.Location = new System.Drawing.Point(120, 174);
            this.btBagi.Name = "btBagi";
            this.btBagi.Size = new System.Drawing.Size(69, 29);
            this.btBagi.TabIndex = 9;
            this.btBagi.Text = "/";
            this.btBagi.UseVisualStyleBackColor = true;
            this.btBagi.Click += new System.EventHandler(this.btBagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 224);
            this.Controls.Add(this.btBagi);
            this.Controls.Add(this.btKali);
            this.Controls.Add(this.btKurang);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.etHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.etB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox etA;
        private System.Windows.Forms.TextBox etB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Button btKurang;
        private System.Windows.Forms.Button btKali;
        private System.Windows.Forms.Button btBagi;
    }
}

