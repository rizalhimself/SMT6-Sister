
namespace P1_Sister_11116
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.lbRecords = new System.Windows.Forms.Label();
            this.etAlamat = new System.Windows.Forms.TextBox();
            this.etNama = new System.Windows.Forms.TextBox();
            this.etCostumer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.btIdKostumer = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btLast);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.btPrev);
            this.panel1.Controls.Add(this.btFirst);
            this.panel1.Controls.Add(this.lbRecords);
            this.panel1.Controls.Add(this.etAlamat);
            this.panel1.Controls.Add(this.etNama);
            this.panel1.Controls.Add(this.etCostumer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbNama);
            this.panel1.Controls.Add(this.btIdKostumer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 183);
            this.panel1.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(433, 142);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(352, 142);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(271, 142);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 23);
            this.btLast.TabIndex = 10;
            this.btLast.Text = "Last";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(190, 142);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 9;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(109, 142);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 8;
            this.btPrev.Text = "Prev";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(28, 142);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(75, 23);
            this.btFirst.TabIndex = 7;
            this.btFirst.Text = "First";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Location = new System.Drawing.Point(430, 10);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(92, 13);
            this.lbRecords.TabIndex = 6;
            this.lbRecords.Text = "Total Records = 0";
            // 
            // etAlamat
            // 
            this.etAlamat.Location = new System.Drawing.Point(111, 92);
            this.etAlamat.Name = "etAlamat";
            this.etAlamat.Size = new System.Drawing.Size(397, 20);
            this.etAlamat.TabIndex = 5;
            // 
            // etNama
            // 
            this.etNama.Location = new System.Drawing.Point(111, 60);
            this.etNama.Name = "etNama";
            this.etNama.Size = new System.Drawing.Size(235, 20);
            this.etNama.TabIndex = 4;
            // 
            // etCostumer
            // 
            this.etCostumer.Location = new System.Drawing.Point(111, 28);
            this.etCostumer.Name = "etCostumer";
            this.etCostumer.Size = new System.Drawing.Size(100, 20);
            this.etCostumer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(25, 63);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 1;
            this.lbNama.Text = "Nama";
            // 
            // btIdKostumer
            // 
            this.btIdKostumer.AutoSize = true;
            this.btIdKostumer.Location = new System.Drawing.Point(25, 31);
            this.btIdKostumer.Name = "btIdKostumer";
            this.btIdKostumer.Size = new System.Drawing.Size(63, 13);
            this.btIdKostumer.TabIndex = 0;
            this.btIdKostumer.Text = "Id Costumer";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(401, 201);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(320, 201);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 14;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(482, 201);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 15;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 236);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.TextBox etAlamat;
        private System.Windows.Forms.TextBox etNama;
        private System.Windows.Forms.TextBox etCostumer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label btIdKostumer;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btExit;
    }
}

