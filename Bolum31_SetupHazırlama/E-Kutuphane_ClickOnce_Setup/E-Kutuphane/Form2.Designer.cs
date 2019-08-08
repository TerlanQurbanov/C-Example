namespace E_Kutuphane
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbKitapKayit = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaskiNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmdanamenu = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgwKitap = new System.Windows.Forms.DataGridView();
            this.tbKullanici = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgwKullanici = new System.Windows.Forms.DataGridView();
            this.btnAnamenu = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbKitapKayit.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitap)).BeginInit();
            this.tbKullanici.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbKitapKayit);
            this.tabControl1.Controls.Add(this.tbKullanici);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tbKitapKayit
            // 
            this.tbKitapKayit.Controls.Add(this.GroupBox1);
            this.tbKitapKayit.Controls.Add(this.GroupBox2);
            this.tbKitapKayit.Controls.Add(this.dgwKitap);
            this.tbKitapKayit.Location = new System.Drawing.Point(4, 22);
            this.tbKitapKayit.Name = "tbKitapKayit";
            this.tbKitapKayit.Padding = new System.Windows.Forms.Padding(3);
            this.tbKitapKayit.Size = new System.Drawing.Size(614, 406);
            this.tbKitapKayit.TabIndex = 0;
            this.tbKitapKayit.Text = "Kitap Kayıt";
            this.tbKitapKayit.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblKayitSayisi);
            this.GroupBox1.Controls.Add(this.txtDurum);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.txtAdet);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.txtBaskiNo);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.txtYazarAdi);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.txtkitapadi);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(6, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(364, 182);
            this.GroupBox1.TabIndex = 49;
            this.GroupBox1.TabStop = false;
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(17, 156);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(16, 13);
            this.lblKayitSayisi.TabIndex = 11;
            this.lblKayitSayisi.Text = "...";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(109, 124);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(234, 20);
            this.txtDurum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mevcut Durumu :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(280, 88);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(63, 20);
            this.txtAdet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adedi :";
            // 
            // txtBaskiNo
            // 
            this.txtBaskiNo.Location = new System.Drawing.Point(110, 88);
            this.txtBaskiNo.Name = "txtBaskiNo";
            this.txtBaskiNo.Size = new System.Drawing.Size(62, 20);
            this.txtBaskiNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baskı No :";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(113, 53);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(233, 20);
            this.txtYazarAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar Adı :";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(113, 22);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(233, 20);
            this.txtkitapadi.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Kitap Adı :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSil);
            this.GroupBox2.Controls.Add(this.cmdanamenu);
            this.GroupBox2.Controls.Add(this.btnGuncelle);
            this.GroupBox2.Controls.Add(this.btnEkle);
            this.GroupBox2.Location = new System.Drawing.Point(390, 15);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(217, 182);
            this.GroupBox2.TabIndex = 50;
            this.GroupBox2.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(42, 91);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 30);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmdanamenu
            // 
            this.cmdanamenu.Location = new System.Drawing.Point(42, 139);
            this.cmdanamenu.Name = "cmdanamenu";
            this.cmdanamenu.Size = new System.Drawing.Size(148, 30);
            this.cmdanamenu.TabIndex = 47;
            this.cmdanamenu.Text = "Ana Menü";
            this.cmdanamenu.UseVisualStyleBackColor = true;
            this.cmdanamenu.Click += new System.EventHandler(this.cmdanamenu_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(42, 47);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(148, 30);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(42, 11);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(148, 30);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgwKitap
            // 
            this.dgwKitap.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKitap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwKitap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgwKitap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwKitap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwKitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitap.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKitap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwKitap.GridColor = System.Drawing.Color.Blue;
            this.dgwKitap.Location = new System.Drawing.Point(6, 214);
            this.dgwKitap.Name = "dgwKitap";
            this.dgwKitap.ReadOnly = true;
            this.dgwKitap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.dgwKitap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwKitap.Size = new System.Drawing.Size(599, 174);
            this.dgwKitap.TabIndex = 51;
            this.dgwKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitap_CellClick);
            // 
            // tbKullanici
            // 
            this.tbKullanici.Controls.Add(this.groupBox5);
            this.tbKullanici.Location = new System.Drawing.Point(4, 22);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Padding = new System.Windows.Forms.Padding(3);
            this.tbKullanici.Size = new System.Drawing.Size(614, 406);
            this.tbKullanici.TabIndex = 1;
            this.tbKullanici.Text = "Kullanıcı Ayarları";
            this.tbKullanici.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgwKullanici);
            this.groupBox5.Controls.Add(this.btnAnamenu);
            this.groupBox5.Controls.Add(this.btnKaydet);
            this.groupBox5.Controls.Add(this.txtSifre);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtKullaniciAdi);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(8, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 221);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            // 
            // dgwKullanici
            // 
            this.dgwKullanici.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKullanici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKullanici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwKullanici.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgwKullanici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwKullanici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgwKullanici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanici.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKullanici.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgwKullanici.GridColor = System.Drawing.Color.Blue;
            this.dgwKullanici.Location = new System.Drawing.Point(6, 98);
            this.dgwKullanici.Name = "dgwKullanici";
            this.dgwKullanici.ReadOnly = true;
            this.dgwKullanici.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            this.dgwKullanici.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgwKullanici.Size = new System.Drawing.Size(340, 67);
            this.dgwKullanici.TabIndex = 52;
            this.dgwKullanici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanici_CellClick);
            // 
            // btnAnamenu
            // 
            this.btnAnamenu.Location = new System.Drawing.Point(198, 180);
            this.btnAnamenu.Name = "btnAnamenu";
            this.btnAnamenu.Size = new System.Drawing.Size(148, 30);
            this.btnAnamenu.TabIndex = 48;
            this.btnAnamenu.Text = "Ana Menü";
            this.btnAnamenu.UseVisualStyleBackColor = true;
            this.btnAnamenu.Click += new System.EventHandler(this.btnAnamenu_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(6, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 30);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(113, 53);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(233, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(113, 22);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(233, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Kullanıcı Adı :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbKitapKayit.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitap)).EndInit();
            this.tbKullanici.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbKitapKayit;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtkitapadi;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabPage tbKullanici;
        internal System.Windows.Forms.TextBox txtDurum;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtAdet;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtBaskiNo;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtYazarAdi;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSil;
        internal System.Windows.Forms.Button cmdanamenu;
        internal System.Windows.Forms.Button btnGuncelle;
        internal System.Windows.Forms.Button btnEkle;
        internal System.Windows.Forms.DataGridView dgwKitap;
        private System.Windows.Forms.Label lblKayitSayisi;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Button btnAnamenu;
        internal System.Windows.Forms.Button btnKaydet;
        internal System.Windows.Forms.TextBox txtSifre;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtKullaniciAdi;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.DataGridView dgwKullanici;
    }
}