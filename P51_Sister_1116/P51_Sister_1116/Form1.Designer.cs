namespace P51_Sister_1116
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
            this.etCelcius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btKonversi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.etReamur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.etFahrenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.etKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // etCelcius
            // 
            this.etCelcius.Location = new System.Drawing.Point(140, 12);
            this.etCelcius.Name = "etCelcius";
            this.etCelcius.Size = new System.Drawing.Size(121, 20);
            this.etCelcius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suhu Celcius";
            // 
            // btKonversi
            // 
            this.btKonversi.Location = new System.Drawing.Point(23, 48);
            this.btKonversi.Name = "btKonversi";
            this.btKonversi.Size = new System.Drawing.Size(238, 29);
            this.btKonversi.TabIndex = 2;
            this.btKonversi.Text = "Konversi";
            this.btKonversi.UseVisualStyleBackColor = true;
            this.btKonversi.Click += new System.EventHandler(this.btKonversi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suhu Reamur";
            // 
            // etReamur
            // 
            this.etReamur.Location = new System.Drawing.Point(140, 96);
            this.etReamur.Name = "etReamur";
            this.etReamur.Size = new System.Drawing.Size(121, 20);
            this.etReamur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suhu Fahrenheit";
            // 
            // etFahrenheit
            // 
            this.etFahrenheit.Location = new System.Drawing.Point(140, 122);
            this.etFahrenheit.Name = "etFahrenheit";
            this.etFahrenheit.Size = new System.Drawing.Size(121, 20);
            this.etFahrenheit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Suhu Kelvin";
            // 
            // etKelvin
            // 
            this.etKelvin.Location = new System.Drawing.Point(140, 148);
            this.etKelvin.Name = "etKelvin";
            this.etKelvin.Size = new System.Drawing.Size(121, 20);
            this.etKelvin.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etKelvin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.etFahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etReamur);
            this.Controls.Add(this.btKonversi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etCelcius);
            this.Name = "Form1";
            this.Text = "Konversi Suhu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox etCelcius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKonversi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etReamur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etFahrenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox etKelvin;
    }
}

