namespace Maliyet_ProjeNew
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtMalzemeNot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMalzemeStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMalzemeAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalzemeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUrunMFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunSFiyat = new System.Windows.Forms.TextBox();
            this.BtnUrunGüncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbMalzeme = new System.Windows.Forms.ComboBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.TxtMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnUrunOluştur = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnMalzemeListesi = new System.Windows.Forms.Button();
            this.BtnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.TxtMalzemeNot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtMalzemeStok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMalzemeAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMalzemeid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnMalzemeEkle);
            this.groupBox1.Location = new System.Drawing.Point(28, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEME GİRİŞİ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TxtMalzemeNot
            // 
            this.TxtMalzemeNot.Location = new System.Drawing.Point(78, 215);
            this.TxtMalzemeNot.Name = "TxtMalzemeNot";
            this.TxtMalzemeNot.Size = new System.Drawing.Size(116, 25);
            this.TxtMalzemeNot.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "NOTLAR:";
            // 
            // TxtMalzemeFiyat
            // 
            this.TxtMalzemeFiyat.Location = new System.Drawing.Point(78, 173);
            this.TxtMalzemeFiyat.Name = "TxtMalzemeFiyat";
            this.TxtMalzemeFiyat.Size = new System.Drawing.Size(116, 25);
            this.TxtMalzemeFiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "FİYAT:";
            // 
            // TxtMalzemeStok
            // 
            this.TxtMalzemeStok.Location = new System.Drawing.Point(78, 130);
            this.TxtMalzemeStok.Name = "TxtMalzemeStok";
            this.TxtMalzemeStok.Size = new System.Drawing.Size(116, 25);
            this.TxtMalzemeStok.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "STOK:";
            // 
            // TxtMalzemeAd
            // 
            this.TxtMalzemeAd.Location = new System.Drawing.Point(78, 88);
            this.TxtMalzemeAd.Name = "TxtMalzemeAd";
            this.TxtMalzemeAd.Size = new System.Drawing.Size(116, 25);
            this.TxtMalzemeAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "AD:";
            // 
            // TxtMalzemeid
            // 
            this.TxtMalzemeid.Location = new System.Drawing.Point(78, 47);
            this.TxtMalzemeid.Name = "TxtMalzemeid";
            this.TxtMalzemeid.Size = new System.Drawing.Size(116, 25);
            this.TxtMalzemeid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(78, 259);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(116, 31);
            this.BtnMalzemeEkle.TabIndex = 0;
            this.BtnMalzemeEkle.Text = "Malzeme Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(28, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(78, 259);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(116, 31);
            this.BtnUrunEkle.TabIndex = 0;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID:";
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(78, 47);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(116, 25);
            this.TxtUrunID.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "AD:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(78, 88);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(116, 25);
            this.TxtUrunAd.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "STOK:";
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(78, 130);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(116, 25);
            this.TxtUrunStok.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "M.FİYAT:";
            // 
            // TxtUrunMFiyat
            // 
            this.TxtUrunMFiyat.Location = new System.Drawing.Point(78, 173);
            this.TxtUrunMFiyat.Name = "TxtUrunMFiyat";
            this.TxtUrunMFiyat.Size = new System.Drawing.Size(116, 25);
            this.TxtUrunMFiyat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "S.FİYAT:";
            // 
            // TxtUrunSFiyat
            // 
            this.TxtUrunSFiyat.Location = new System.Drawing.Point(78, 215);
            this.TxtUrunSFiyat.Name = "TxtUrunSFiyat";
            this.TxtUrunSFiyat.Size = new System.Drawing.Size(116, 25);
            this.TxtUrunSFiyat.TabIndex = 10;
            // 
            // BtnUrunGüncelle
            // 
            this.BtnUrunGüncelle.Location = new System.Drawing.Point(78, 296);
            this.BtnUrunGüncelle.Name = "BtnUrunGüncelle";
            this.BtnUrunGüncelle.Size = new System.Drawing.Size(116, 27);
            this.BtnUrunGüncelle.TabIndex = 11;
            this.BtnUrunGüncelle.Text = "Güncelle";
            this.BtnUrunGüncelle.UseVisualStyleBackColor = true;
            this.BtnUrunGüncelle.Click += new System.EventHandler(this.BtnUrunGüncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUrunGüncelle);
            this.groupBox3.Controls.Add(this.TxtUrunSFiyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtUrunMFiyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtUrunStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtUrunID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.BtnUrunEkle);
            this.groupBox3.Location = new System.Drawing.Point(323, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 329);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN GİRİŞİ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmbMalzeme);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Controls.Add(this.TxtMaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TxtMiktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.BtnUrunOluştur);
            this.groupBox4.Location = new System.Drawing.Point(567, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 329);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜRÜN OLUŞTUR";
            // 
            // CmbMalzeme
            // 
            this.CmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMalzeme.FormattingEnabled = true;
            this.CmbMalzeme.Location = new System.Drawing.Point(96, 85);
            this.CmbMalzeme.Name = "CmbMalzeme";
            this.CmbMalzeme.Size = new System.Drawing.Size(121, 26);
            this.CmbMalzeme.TabIndex = 10;
            this.CmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.CmbMalzeme_SelectedIndexChanged);
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(96, 44);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(121, 26);
            this.CmbUrun.TabIndex = 9;
            // 
            // TxtMaliyet
            // 
            this.TxtMaliyet.Location = new System.Drawing.Point(96, 170);
            this.TxtMaliyet.Name = "TxtMaliyet";
            this.TxtMaliyet.Size = new System.Drawing.Size(116, 25);
            this.TxtMaliyet.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "MALİYET:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(96, 127);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(116, 25);
            this.TxtMiktar.TabIndex = 6;
            this.TxtMiktar.TextChanged += new System.EventHandler(this.TxtMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "MALZEME:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "ÜRÜN:";
            // 
            // BtnUrunOluştur
            // 
            this.BtnUrunOluştur.Location = new System.Drawing.Point(96, 218);
            this.BtnUrunOluştur.Name = "BtnUrunOluştur";
            this.BtnUrunOluştur.Size = new System.Drawing.Size(116, 31);
            this.BtnUrunOluştur.TabIndex = 0;
            this.BtnUrunOluştur.Text = "EKLE";
            this.BtnUrunOluştur.UseVisualStyleBackColor = true;
            this.BtnUrunOluştur.Click += new System.EventHandler(this.BtnUrunOluştur_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnCikis);
            this.groupBox5.Controls.Add(this.BtnKasa);
            this.groupBox5.Controls.Add(this.BtnMalzemeListesi);
            this.groupBox5.Controls.Add(this.BtnUrunListesi);
            this.groupBox5.Location = new System.Drawing.Point(824, 398);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 210);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İŞLEMLER";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(18, 173);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(184, 31);
            this.BtnCikis.TabIndex = 3;
            this.BtnCikis.Text = "ÇIKIŞ";
            this.BtnCikis.UseVisualStyleBackColor = true;
            // 
            // BtnKasa
            // 
            this.BtnKasa.Location = new System.Drawing.Point(18, 127);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(184, 31);
            this.BtnKasa.TabIndex = 2;
            this.BtnKasa.Text = "KASA";
            this.BtnKasa.UseVisualStyleBackColor = true;
            this.BtnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // BtnMalzemeListesi
            // 
            this.BtnMalzemeListesi.Location = new System.Drawing.Point(18, 82);
            this.BtnMalzemeListesi.Name = "BtnMalzemeListesi";
            this.BtnMalzemeListesi.Size = new System.Drawing.Size(184, 31);
            this.BtnMalzemeListesi.TabIndex = 1;
            this.BtnMalzemeListesi.Text = "MALZEME LİSTESİ";
            this.BtnMalzemeListesi.UseVisualStyleBackColor = true;
            this.BtnMalzemeListesi.Click += new System.EventHandler(this.button7_Click);
            // 
            // BtnUrunListesi
            // 
            this.BtnUrunListesi.Location = new System.Drawing.Point(18, 41);
            this.BtnUrunListesi.Name = "BtnUrunListesi";
            this.BtnUrunListesi.Size = new System.Drawing.Size(184, 31);
            this.BtnUrunListesi.TabIndex = 0;
            this.BtnUrunListesi.Text = "ÜRÜN LİSTESİ";
            this.BtnUrunListesi.UseVisualStyleBackColor = true;
            this.BtnUrunListesi.Click += new System.EventHandler(this.BtnUrunListesi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(824, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(222, 329);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ÜRÜN OLUŞTUR";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 305);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMalzemeNot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMalzemeFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMalzemeStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMalzemeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalzemeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUrunMFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunSFiyat;
        private System.Windows.Forms.Button BtnUrunGüncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnUrunOluştur;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnMalzemeListesi;
        private System.Windows.Forms.Button BtnUrunListesi;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CmbMalzeme;
        private System.Windows.Forms.ComboBox CmbUrun;
    }
}

