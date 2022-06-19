
namespace P3_Sister_1116
{
    partial class halamanDepan
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
            this.btChatApp = new System.Windows.Forms.Button();
            this.btSerialCommunication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btChatApp
            // 
            this.btChatApp.Location = new System.Drawing.Point(12, 67);
            this.btChatApp.Name = "btChatApp";
            this.btChatApp.Size = new System.Drawing.Size(109, 59);
            this.btChatApp.TabIndex = 0;
            this.btChatApp.Text = "Chat Application";
            this.btChatApp.UseVisualStyleBackColor = true;
            this.btChatApp.Click += new System.EventHandler(this.btChatApp_Click);
            // 
            // btSerialCommunication
            // 
            this.btSerialCommunication.Location = new System.Drawing.Point(127, 67);
            this.btSerialCommunication.Name = "btSerialCommunication";
            this.btSerialCommunication.Size = new System.Drawing.Size(109, 59);
            this.btSerialCommunication.TabIndex = 1;
            this.btSerialCommunication.Text = "Serial Communication";
            this.btSerialCommunication.UseVisualStyleBackColor = true;
            this.btSerialCommunication.Click += new System.EventHandler(this.btSerialCommunication_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disusun Oeh:\r\nRizal Alfikri | 19SA1116 | IF19A\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // halamanDepan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(248, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSerialCommunication);
            this.Controls.Add(this.btChatApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "halamanDepan";
            this.ShowIcon = false;
            this.Text = "Latihan 3 Sister";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChatApp;
        private System.Windows.Forms.Button btSerialCommunication;
        private System.Windows.Forms.Label label1;
    }
}