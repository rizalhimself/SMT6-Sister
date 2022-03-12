using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P1_Sister_11116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aktifkanTextbox(false);
            totalRecord();
        }

        //Pembuatan variabel dasar program
        const int kapasitasAwal = 50;
        string[] arrCustomer = new string[kapasitasAwal];
        int jmlMax = kapasitasAwal;
        int index = -1;
        int jmlCustomer = 0;
        char pemisah = ',';

        private void pisaDataCustomer (string customer)
        {
            //Digunakan untuk memasukkan dan mengkonversi dengan mengsplit/pisah data mentah dari file txt ke dalam array
            char[] pisah = { pemisah };
            string[] dataCustomer = customer.Split(pisah);
            etCostumer.Text = dataCustomer[0];
            etNama.Text = dataCustomer[1];
            etAlamat.Text = dataCustomer[2];
        }

        private void aktifkanTextbox(bool sifatKeaktifan)
        {
            //Method ini digunakan untuk memberikan nilai boolean pada aktivasi textbox program
            etCostumer.Enabled = sifatKeaktifan;
            etNama.Enabled = sifatKeaktifan;
            etAlamat.Enabled = sifatKeaktifan;
        }

        private void bersih()
        {
            //Method ini digunakan untuk mereset/mengclearkan isian pada textbox
            etCostumer.Clear();
            etNama.Clear();
            etAlamat.Clear();
        }

        private void totalRecord()
        {
            //Method ini digunakan untuk menjumlah total data yang terekam pada file txt
            lbRecords.Text = "Total Record = " + jmlCustomer.ToString();
        }

        private void updateDataArray()
        {
            if (jmlCustomer > 0)
            {
                string customer = "";
                customer = customer + etCostumer.Text + pemisah;
                customer = customer + etNama.Text + pemisah;
                customer = customer + etAlamat.Text + pemisah;

                //simpan string ke dalam array
                arrCustomer[index] = customer;
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            DialogResult pilih = dlgOpen.ShowDialog();
            if (pilih == DialogResult.OK)
            {
                arrCustomer = File.ReadAllLines(dlgOpen.FileName);
                jmlCustomer = arrCustomer.Length;
                index = 0;

                //Perbesar ukuran array agar dapat ditambahkan record
                jmlMax = jmlCustomer * 2;
                Array.Resize(ref arrCustomer, jmlMax);

                //Tampilkan data ke text box
                string customer = arrCustomer[index];
                pisaDataCustomer(customer);
                aktifkanTextbox(true);
                totalRecord();
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            updateDataArray();
            SaveFileDialog dlgSave = new SaveFileDialog();
            DialogResult pilih = dlgSave.ShowDialog();
            if (pilih == DialogResult.OK)
            {
                //menyimpan data sebanyak jumlah data yang ada kedalam array dengan cara copy data lama ke aray baru
                string[] arrBantuan = new string[jmlCustomer];
                Array.Copy(arrCustomer, arrBantuan, jmlCustomer);
                File.WriteAllLines(dlgSave.FileName, arrBantuan);
            }
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                index = 0;
                string customer = arrCustomer[index];
                pisaDataCustomer(customer);
                totalRecord();
            }
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                index--;
                if (index < 0)
                {
                    index = 0;
                }
                    
                string customer = arrCustomer[index];
                pisaDataCustomer(customer);
                totalRecord();
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                index++;
                if (index >= jmlCustomer)
                {
                    index = jmlCustomer - 1;
                }
                string customer = arrCustomer[index];
                pisaDataCustomer(customer);
                totalRecord();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            aktifkanTextbox(true);
            updateDataArray();
            if (jmlCustomer == jmlMax)
            {
                jmlMax *= 2;
                Array.Resize(ref arrCustomer, jmlMax);
            }

            bersih();
            etCostumer.Focus();
            index = jmlCustomer;
            jmlCustomer++;
            totalRecord();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                if (index == jmlCustomer - 1)
                    index--;
                else
                {
                    for (int i = index; i < jmlCustomer; i++)
                    {
                        arrCustomer[i] = arrCustomer[i + 1];
                    }
                }

                jmlCustomer--;

                if (jmlCustomer > 0)
                {
                    string customer = arrCustomer[index];
                    pisaDataCustomer(customer);
                } else
                {
                    bersih();
                    aktifkanTextbox(false);
                }

                totalRecord();
            }
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            updateDataArray();
            if (jmlCustomer > 0)
            {
                index = jmlCustomer - 1;
                string customer = arrCustomer[index];
                pisaDataCustomer(customer);
                totalRecord();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
