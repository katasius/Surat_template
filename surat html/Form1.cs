using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Microsoft.Win32;

namespace surat_html
{
    public partial class Form1 : Form
    {
        public void IESetupFooter()
        {

            string strKey = "Software\\Microsoft\\Internet Explorer\\PageSetup";
            bool bolWritable = true;
            string strName = "footer";
            object oValue = "www.dwindo.id";
            RegistryKey oKey = Registry.CurrentUser.OpenSubKey(strKey, bolWritable);
            Console.Write(strKey);
            oKey.SetValue(strName, oValue);
            oKey.Close();
        }

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("id-ID");
            InitializeComponent();

        }

       

        private static string terbilang(int angka)
        {
            string hasil = "";
            int x, sisa;

            if (angka >= 1000000)
            {
                x = angka / 1000000;
                if (x > 9) hasil += terbilang(x) + " Juta";
                else hasil += huruf(x) + " Juta";
                sisa = angka % 1000000;
                hasil += terbilang(sisa);
            } 
            else if (angka >= 1000)
            {
                x = angka / 1000;
                if (x == 1) hasil += " Seribu";
                else if (x > 9) hasil += terbilang(x) + " Ribu";
                else hasil += huruf(x) + " Ribu";
                sisa = angka % 1000;
                hasil += terbilang(sisa);
            } 
            else if (angka >= 100)
            {
                x = angka / 100;
                if (x == 1) hasil += " Seratus";
                else hasil += huruf(x) + " Ratus";
                sisa = angka % 100;
                hasil += terbilang(sisa);
            }
            else if (angka == 11)
            {
                hasil += " Sebelas";
            }
            else if (angka >= 20)
            {
                x = angka / 10;
                hasil += huruf(x) + " Puluh";
                sisa = angka % 10;
                hasil += huruf(sisa);
            }
            else if (angka > 10)
            {
                x = angka / 10;
                sisa = angka % 10;
                if (sisa == 1) hasil += " Sepuluh";
                else hasil += huruf(sisa) + " Belas";
            }
            else if (angka == 10) hasil += " Sepuluh";
            else hasil += huruf(angka);
            return hasil;
        }

        public static string huruf(int y) {
          string[] konversi= new string[10] {""," Satu"," Dua"," Tiga",
          " Empat"," Lima"," Enam"," Tujuh"," Delapan"," Sembilan"};
          
         return konversi[y];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IESetupFooter();
            foreach (String file in System.IO.Directory.GetFiles(@"template"))
            {
                if (Path.GetExtension(file) == ".html")
                {
                    var value = Path.GetFileNameWithoutExtension(file);
                    comboBox1.Items.Add(value);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string alamat = textBoxAlamat.Text;
            string noKTP = textBoxNoKTP.Text;
            string persetujuanNama = textBoxPersetujuanNama.Text;
            string persetujuanAlamat = textBoxPersetujuanAlamat.Text;
            string persetujuanNoKTP = textBoxPersetujuanNoKTP.Text;
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
            string tanggal = dateTimePicker1.Value.ToString("dddd, dd MMMM yyyy");
            string namaLeasing = textBoxNamaLeasing.Text;
            string saksi1 = textBoxSaksi1.Text;
            string noKTPSaksi1 = textBoxNoKTPSaksi1.Text;
            string saksi2 = textBoxSaksi2.Text;
            string noKTPSaksi2 = textBoxNoKTPSaksi2.Text;
            string danaCair = textBoxDanaCair.Text;
            string danaAngsuran = textBoxDanaAngsuran.Text;
            string tenorKredit = textBoxTenorKredit.Text;
            string danaTitipan = textBoxDanaTitipan.Text;
            string danaPembatalan = textBoxDanaPembatalan.Text;
            string jenisAsuransi = textBoxJenisAsuransi.Text;
            string tenorAsuransi = textBoxTenorAsuransi.Text;
            string path = comboBox1.Text;
            string readText = File.ReadAllText(@"template\"+path+".html");
            string source = Application.StartupPath;

            webBrowser1.Navigate(source);

            

            webBrowser1.DocumentText = readText.Replace("{{nama}}", nama)
                .Replace("{{source}}", source)
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
                .Replace("{{saksi2}}", saksi2)
                .Replace("{{danaCair}}", Int32.Parse(danaCair).ToString("N0"))
                .Replace("{{danaCairTerbilang}}", terbilang(Int32.Parse(danaCair)))
                .Replace("{{danaAngsuran}}", Int32.Parse(danaAngsuran).ToString("N0"))
                .Replace("{{danaAngsuranTerbilang}}", terbilang(Int32.Parse(danaAngsuran)))
                .Replace("{{tenorKredit}}", tenorKredit)
                .Replace("{{danaTitipan}}", Int32.Parse(danaTitipan).ToString("N0"))
                .Replace("{{danaTitipanTerbilang}}", terbilang(Int32.Parse(danaTitipan)))
                .Replace("{{danaPembatalan}}", Int32.Parse(danaPembatalan).ToString("N0"))
                .Replace("{{danaPembatalanTerbilang}}", terbilang(Int32.Parse(danaPembatalan)))
                .Replace("{{tenorAsuransi}}", tenorAsuransi)
                .Replace("{{tenorAsuransiTerbilang}}", terbilang(Int32.Parse(tenorAsuransi)))
                .Replace("{{jenisAsuransi}}", jenisAsuransi)
                .Replace("{{noKTPSaksi1}}", noKTPSaksi1)
                .Replace("{{noKTPSaksi2}}", noKTPSaksi2)
                .Replace("{{persetujuanAlamat}}", persetujuanAlamat)
                .Replace("{{persetujuanNoKTP}}", persetujuanNoKTP)
                .Replace("{{persetujuanNama}}", persetujuanNama);

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

        private void button2_Click(object sender, EventArgs e)
        {
            //webBrowser1.ShowSaveAsDialog();
           // string path = comboBox1.Text;
           // File.WriteAllText(@"template\" + path + ".html", webBrowser1.Document.Body.Parent.OuterHtml);
            SaveFileDialog sfd = new SaveFileDialog();
            
            if (sfd.ShowDialog() == DialogResult.OK)

            {
                using (System.IO.StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (var control in groupBox1.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox txt = (TextBox)control;
                            sw.WriteLine(txt.Name + "|" + txt.Text);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            using (System.IO.StreamReader sr = new StreamReader(myStream))
                            {
                                string line = "";
                                string control = "";
                                string val = "";

                                while ((line = sr.ReadLine()) != null)
                                {
                                    //Ugly, but work in every case
                                    if (line.IndexOf('|') >= 0)
                                    {
                                        control = line.Substring(0, line.IndexOf('|'));
                                        val = line.Substring(line.IndexOf('|') + 1);
                                    }
                                    else
                                    {
                                        val += "\r\n" + line.Substring(line.IndexOf('|') + 1);
                                    }


                                    if (groupBox1.Controls[control] != null)
                                    {
                                        ((TextBox)groupBox1.Controls[control]).Text = val;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            
        }
    }
}
