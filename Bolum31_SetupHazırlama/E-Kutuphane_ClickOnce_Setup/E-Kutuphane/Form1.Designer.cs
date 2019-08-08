namespace E_Kutuphane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstsonuc = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaranan = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.grpLogOut = new System.Windows.Forms.GroupBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbYazdırmaKriteri = new System.Windows.Forms.ComboBox();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txtKitapAlimTarihi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBaskiNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.cmdcikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.grpLogOut.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstsonuc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
            // 
            // lstsonuc
            // 
            this.lstsonuc.FormattingEnabled = true;
            this.lstsonuc.Location = new System.Drawing.Point(15, 19);
            this.lstsonuc.Name = "lstsonuc";
            this.lstsonuc.Size = new System.Drawing.Size(175, 173);
            this.lstsonuc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAramaKriteri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtaranan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aradığınız Kitap";
            // 
            // cmbAramaKriteri
            // 
            this.cmbAramaKriteri.FormattingEnabled = true;
            this.cmbAramaKriteri.Items.AddRange(new object[] {
            "Kitap Adı",
            "Yazar Adı"});
            this.cmbAramaKriteri.Location = new System.Drawing.Point(308, 23);
            this.cmbAramaKriteri.Name = "cmbAramaKriteri";
            this.cmbAramaKriteri.Size = new System.Drawing.Size(121, 21);
            this.cmbAramaKriteri.TabIndex = 3;
            this.cmbAramaKriteri.SelectedIndexChanged += new System.EventHandler(this.cmbAramaKriteri_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Arama Kriteri :";
            // 
            // txtaranan
            // 
            this.txtaranan.Location = new System.Drawing.Point(15, 19);
            this.txtaranan.Name = "txtaranan";
            this.txtaranan.Size = new System.Drawing.Size(175, 20);
            this.txtaranan.TabIndex = 1;
            this.txtaranan.TextChanged += new System.EventHandler(this.txtaranan_TextChanged);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.txtSifre);
            this.grpLogin.Controls.Add(this.txtKullaniciAdi);
            this.grpLogin.Controls.Add(this.btnGirisYap);
            this.grpLogin.Location = new System.Drawing.Point(464, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(172, 117);
            this.grpLogin.TabIndex = 2;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Giriş Yap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(83, 45);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(83, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(83, 19);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(83, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(37, 84);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(105, 21);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // grpLogOut
            // 
            this.grpLogOut.Controls.Add(this.lblKullaniciAdi);
            this.grpLogOut.Controls.Add(this.btnCikisYap);
            this.grpLogOut.Location = new System.Drawing.Point(464, 142);
            this.grpLogOut.Name = "grpLogOut";
            this.grpLogOut.Size = new System.Drawing.Size(172, 117);
            this.grpLogOut.TabIndex = 7;
            this.grpLogOut.TabStop = false;
            this.grpLogOut.Text = "Çıkış Yap";
            this.grpLogOut.Visible = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(34, 43);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(16, 13);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "...";
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(37, 84);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(105, 21);
            this.btnCikisYap.TabIndex = 0;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbYazdırmaKriteri);
            this.groupBox3.Controls.Add(this.btnYazdır);
            this.groupBox3.Controls.Add(this.btn_Sil);
            this.groupBox3.Controls.Add(this.btn_Kaydet);
            this.groupBox3.Controls.Add(this.btn_Ekle);
            this.groupBox3.Controls.Add(this.txtKitapAlimTarihi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMail);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtNo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSinif);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 199);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alıcının";
            // 
            // cmbYazdırmaKriteri
            // 
            this.cmbYazdırmaKriteri.FormattingEnabled = true;
            this.cmbYazdırmaKriteri.Items.AddRange(new object[] {
            "Tüm Kitaplar"});
            this.cmbYazdırmaKriteri.Location = new System.Drawing.Point(281, 154);
            this.cmbYazdırmaKriteri.Name = "cmbYazdırmaKriteri";
            this.cmbYazdırmaKriteri.Size = new System.Drawing.Size(82, 21);
            this.cmbYazdırmaKriteri.TabIndex = 22;
            // 
            // btnYazdır
            // 
            this.btnYazdır.Enabled = false;
            this.btnYazdır.Location = new System.Drawing.Point(369, 149);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(60, 30);
            this.btnYazdır.TabIndex = 21;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Enabled = false;
            this.btn_Sil.Location = new System.Drawing.Point(281, 109);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(148, 30);
            this.btn_Sil.TabIndex = 20;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Enabled = false;
            this.btn_Kaydet.Location = new System.Drawing.Point(281, 66);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(148, 30);
            this.btn_Kaydet.TabIndex = 19;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Enabled = false;
            this.btn_Ekle.Location = new System.Drawing.Point(281, 24);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(148, 30);
            this.btn_Ekle.TabIndex = 18;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txtKitapAlimTarihi
            // 
            this.txtKitapAlimTarihi.Location = new System.Drawing.Point(101, 166);
            this.txtKitapAlimTarihi.Name = "txtKitapAlimTarihi";
            this.txtKitapAlimTarihi.Size = new System.Drawing.Size(126, 20);
            this.txtKitapAlimTarihi.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kitap Alım Tarihi :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(71, 140);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(155, 20);
            this.txtMail.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "E-Posta :";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(71, 109);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(156, 20);
            this.txtNo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Numarası :";
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(71, 76);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(155, 20);
            this.txtSinif.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sınıfı :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(71, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Soyadı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(71, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 20);
            this.txtAd.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adı :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDurum);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAdet);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtBaskiNo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtYazarAdi);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtKitapAdi);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(227, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 197);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(57, 139);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(158, 20);
            this.txtDurum.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Durumu :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(171, 103);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(44, 20);
            this.txtAdet.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Adedi :";
            // 
            // txtBaskiNo
            // 
            this.txtBaskiNo.Location = new System.Drawing.Point(58, 103);
            this.txtBaskiNo.Name = "txtBaskiNo";
            this.txtBaskiNo.Size = new System.Drawing.Size(61, 20);
            this.txtBaskiNo.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Baskı No :";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(61, 68);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(154, 20);
            this.txtYazarAdi.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Yazarı :";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(61, 37);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(154, 20);
            this.txtKitapAdi.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Adı :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(477, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 75);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hazırlayan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Volkan AKTAŞ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAyarlar);
            this.groupBox6.Controls.Add(this.cmdcikis);
            this.groupBox6.Location = new System.Drawing.Point(477, 421);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(158, 60);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(85, 14);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(67, 35);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Visible = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // cmdcikis
            // 
            this.cmdcikis.Location = new System.Drawing.Point(6, 14);
            this.cmdcikis.Name = "cmdcikis";
            this.cmdcikis.Size = new System.Drawing.Size(67, 35);
            this.cmdcikis.TabIndex = 3;
            this.cmdcikis.Text = "Çıkış";
            this.cmdcikis.UseVisualStyleBackColor = true;
            this.cmdcikis.Click += new System.EventHandler(this.cmdcikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpLogOut);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Kütüphane Versiyon 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpLogOut.ResumeLayout(false);
            this.grpLogOut.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstsonuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaranan;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.GroupBox grpLogOut;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnCikisYap;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtMail;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtNo;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtSinif;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtSoyad;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtAd;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtKitapAlimTarihi;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAramaKriteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.TextBox txtDurum;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtAdet;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtBaskiNo;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtYazarAdi;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtKitapAdi;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Button btn_Kaydet;
        internal System.Windows.Forms.Button btn_Ekle;
        internal System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button cmdcikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbYazdırmaKriteri;
        internal System.Windows.Forms.Button btnYazdır;
    }
}

