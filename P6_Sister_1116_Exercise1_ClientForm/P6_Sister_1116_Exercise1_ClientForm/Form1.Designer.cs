namespace P6_Sister_1116_Exercise1_ClientForm
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
            this.btKonversi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etAngka = new System.Windows.Forms.TextBox();
            this.etPredikat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btKonversi
            // 
            this.btKonversi.Location = new System.Drawing.Point(15, 59);
            this.btKonversi.Name = "btKonversi";
            this.btKonversi.Size = new System.Drawing.Size(172, 23);
            this.btKonversi.TabIndex = 0;
            this.btKonversi.Text = "Konversi";
            this.btKonversi.UseVisualStyleBackColor = true;
            this.btKonversi.Click += new System.EventHandler(this.btKonversi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nilai Angka";
            // 
            // etAngka
            // 
            this.etAngka.Location = new System.Drawing.Point(87, 20);
            this.etAngka.Name = "etAngka";
            this.etAngka.Size = new System.Drawing.Size(100, 20);
            this.etAngka.TabIndex = 2;
            // 
            // etPredikat
            // 
            this.etPredikat.Location = new System.Drawing.Point(87, 109);
            this.etPredikat.Name = "etPredikat";
            this.etPredikat.Size = new System.Drawing.Size(100, 20);
            this.etPredikat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Predikat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 143);
            this.Controls.Add(this.etPredikat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etAngka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btKonversi);
            this.Name = "Form1";
            this.Text = "Konversi Nilai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btKonversi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox etAngka;
        private System.Windows.Forms.TextBox etPredikat;
        private System.Windows.Forms.Label label2;
    }
}

