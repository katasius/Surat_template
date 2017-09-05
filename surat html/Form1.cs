using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace surat_html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(@"C:\Users\herdi\Desktop\Testing");

            this.comboBox1.Items.AddRange(files);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string alamat = textBoxAlamat.Text;
            string noKTP = textBoxNoKTP.Text;
            string telepon = textBoxTelepon.Text;
            string merkKendaraan = textBoxMerkKendaraan.Text;
            string typeKendaraan = textBoxTypeKendaraan.Text;
            string noPolisi = textBoxNoPolisi.Text;
            string thnBuat = textBoxThnBuat.Text;
            string noMesin = textBoxNoMesin.Text;
            string noRangka = textBoxNoRangka.Text;
            string namaBPKB = textBoxNamaBPKB.Text;
            string noBPKB = textBoxNoBPKB.Text;
            string alamatBPKB = textBoxAlamatBPKB.Text;
            string tanggal = dateTimePicker1.Value.AddDays(1).ToString("dddd, dd MMMM yyyy");
            string namaLeasing = textBoxNamaLeasing.Text;
            string saksi1 = textBoxSaksi1.Text;
            string saksi2 = textBoxSaksi2.Text;
            string path = comboBox1.Text;
            string readText = File.ReadAllText(path);

            webBrowser1.DocumentText = readText.Replace("{{nama}}", nama)
                .Replace("{{alamat}}", alamat)
                .Replace("{{noKTP}}", noKTP)
                .Replace("{{telepon}}", telepon)
                .Replace("{{merkKendaraan}}", merkKendaraan)
                .Replace("{{typeKendaraan}}", typeKendaraan)
                .Replace("{{noPolisi}}", noPolisi)
                .Replace("{{thnBuat}}", thnBuat)
                .Replace("{{noMesin}}", noMesin)
                .Replace("{{noRangka}}", noRangka)
                .Replace("{{namaBPKB}}", namaBPKB)
                .Replace("{{alamatBPKB}}", alamatBPKB)
                .Replace("{{tanggal}}", tanggal)
                .Replace("{{namaLeasing}}", namaLeasing)
                .Replace("{{saksi1}}", saksi1)
                .Replace("{{saksi2}}", saksi2);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
