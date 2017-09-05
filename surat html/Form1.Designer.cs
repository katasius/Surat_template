namespace surat_html
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTelepon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNoKTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAlamatBPKB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNoBPKB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNamaBPKB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNoRangka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNoPolisi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNoMesin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThnBuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMerkKendaraan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTypeKendaraan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSaksi2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSaksi1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNamaLeasing = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(126, 48);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(203, 56);
            this.textBoxAlamat.TabIndex = 1;
            this.textBoxAlamat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(126, 22);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(203, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alamat";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 430);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(772, 323);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTelepon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNoKTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAlamat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pribadi";
            // 
            // textBoxTelepon
            // 
            this.textBoxTelepon.Location = new System.Drawing.Point(126, 138);
            this.textBoxTelepon.Name = "textBoxTelepon";
            this.textBoxTelepon.Size = new System.Drawing.Size(203, 20);
            this.textBoxTelepon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "No Telepon";
            // 
            // textBoxNoKTP
            // 
            this.textBoxNoKTP.Location = new System.Drawing.Point(126, 109);
            this.textBoxNoKTP.Name = "textBoxNoKTP";
            this.textBoxNoKTP.Size = new System.Drawing.Size(203, 20);
            this.textBoxNoKTP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "No KTP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAlamatBPKB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxNoBPKB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxNamaBPKB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxNoRangka);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxNoPolisi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxNoMesin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxThnBuat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxMerkKendaraan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxTypeKendaraan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(396, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 271);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Kendaraan";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxAlamatBPKB
            // 
            this.textBoxAlamatBPKB.Location = new System.Drawing.Point(154, 230);
            this.textBoxAlamatBPKB.Name = "textBoxAlamatBPKB";
            this.textBoxAlamatBPKB.Size = new System.Drawing.Size(203, 20);
            this.textBoxAlamatBPKB.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Alamat BPKB";
            // 
            // textBoxNoBPKB
            // 
            this.textBoxNoBPKB.Location = new System.Drawing.Point(154, 204);
            this.textBoxNoBPKB.Name = "textBoxNoBPKB";
            this.textBoxNoBPKB.Size = new System.Drawing.Size(203, 20);
            this.textBoxNoBPKB.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "No BPKB";
            // 
            // textBoxNamaBPKB
            // 
            this.textBoxNamaBPKB.Location = new System.Drawing.Point(154, 178);
            this.textBoxNamaBPKB.Name = "textBoxNamaBPKB";
            this.textBoxNamaBPKB.Size = new System.Drawing.Size(203, 20);
            this.textBoxNamaBPKB.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nama BPKB";
            // 
            // textBoxNoRangka
            // 
            this.textBoxNoRangka.Location = new System.Drawing.Point(154, 152);
            this.textBoxNoRangka.Name = "textBoxNoRangka";
            this.textBoxNoRangka.Size = new System.Drawing.Size(203, 20);
            this.textBoxNoRangka.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "No Rangka";
            // 
            // textBoxNoPolisi
            // 
            this.textBoxNoPolisi.Location = new System.Drawing.Point(154, 74);
            this.textBoxNoPolisi.Name = "textBoxNoPolisi";
            this.textBoxNoPolisi.Size = new System.Drawing.Size(203, 20);
            this.textBoxNoPolisi.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "No Polisi";
            // 
            // textBoxNoMesin
            // 
            this.textBoxNoMesin.Location = new System.Drawing.Point(154, 126);
            this.textBoxNoMesin.Name = "textBoxNoMesin";
            this.textBoxNoMesin.Size = new System.Drawing.Size(203, 20);
            this.textBoxNoMesin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "No Mesin";
            // 
            // textBoxThnBuat
            // 
            this.textBoxThnBuat.Location = new System.Drawing.Point(154, 100);
            this.textBoxThnBuat.Name = "textBoxThnBuat";
            this.textBoxThnBuat.Size = new System.Drawing.Size(203, 20);
            this.textBoxThnBuat.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tahun Pembuatan";
            // 
            // textBoxMerkKendaraan
            // 
            this.textBoxMerkKendaraan.Location = new System.Drawing.Point(154, 22);
            this.textBoxMerkKendaraan.Name = "textBoxMerkKendaraan";
            this.textBoxMerkKendaraan.Size = new System.Drawing.Size(203, 20);
            this.textBoxMerkKendaraan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Merk Kendaraan";
            // 
            // textBoxTypeKendaraan
            // 
            this.textBoxTypeKendaraan.Location = new System.Drawing.Point(154, 48);
            this.textBoxTypeKendaraan.Name = "textBoxTypeKendaraan";
            this.textBoxTypeKendaraan.Size = new System.Drawing.Size(203, 20);
            this.textBoxTypeKendaraan.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Type Kendaraan";
            // 
            // textBoxSaksi2
            // 
            this.textBoxSaksi2.Location = new System.Drawing.Point(538, 48);
            this.textBoxSaksi2.Name = "textBoxSaksi2";
            this.textBoxSaksi2.Size = new System.Drawing.Size(203, 20);
            this.textBoxSaksi2.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBoxSaksi2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxSaksi1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBoxNamaLeasing);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 126);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info Lain";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(409, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Saksi 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Saksi 2";
            // 
            // textBoxSaksi1
            // 
            this.textBoxSaksi1.Location = new System.Drawing.Point(538, 22);
            this.textBoxSaksi1.Name = "textBoxSaksi1";
            this.textBoxSaksi1.Size = new System.Drawing.Size(203, 20);
            this.textBoxSaksi1.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Dokumen";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tanggal";
            // 
            // textBoxNamaLeasing
            // 
            this.textBoxNamaLeasing.Location = new System.Drawing.Point(126, 48);
            this.textBoxNamaLeasing.Name = "textBoxNamaLeasing";
            this.textBoxNamaLeasing.Size = new System.Drawing.Size(203, 20);
            this.textBoxNamaLeasing.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Nama Leasing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 765);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTelepon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNoKTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxAlamatBPKB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNoBPKB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNamaBPKB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNoRangka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNoPolisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNoMesin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxThnBuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMerkKendaraan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTypeKendaraan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSaksi2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSaksi1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxNamaLeasing;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

