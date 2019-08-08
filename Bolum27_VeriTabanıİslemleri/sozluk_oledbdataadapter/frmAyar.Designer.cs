namespace sozluk_oledbdataadapter
{
    partial class frmAyar
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lstsonuc = new System.Windows.Forms.ListBox();
            this.txtturkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtingilizce = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSil);
            this.GroupBox2.Controls.Add(this.btnTemizle);
            this.GroupBox2.Controls.Add(this.btnGuncelle);
            this.GroupBox2.Controls.Add(this.btnAnasayfa);
            this.GroupBox2.Controls.Add(this.btnEkle);
            this.GroupBox2.Location = new System.Drawing.Point(7, 307);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(498, 52);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(303, 15);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(6, 15);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 28;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(207, 15);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(397, 15);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnasayfa.TabIndex = 26;
            this.btnAnasayfa.Text = "Ana Sayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(107, 15);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 25;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(242, 63);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(263, 238);
            this.txtsonuc.TabIndex = 23;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.txtsonuc);
            this.GroupBox1.Controls.Add(this.lstsonuc);
            this.GroupBox1.Controls.Add(this.txtturkce);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.txtingilizce);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(512, 370);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // lstsonuc
            // 
            this.lstsonuc.FormattingEnabled = true;
            this.lstsonuc.Location = new System.Drawing.Point(7, 63);
            this.lstsonuc.Name = "lstsonuc";
            this.lstsonuc.Size = new System.Drawing.Size(212, 238);
            this.lstsonuc.TabIndex = 22;
            this.lstsonuc.SelectedIndexChanged += new System.EventHandler(this.lstsonuc_SelectedIndexChanged);
            // 
            // txtturkce
            // 
            this.txtturkce.Location = new System.Drawing.Point(310, 22);
            this.txtturkce.Name = "txtturkce";
            this.txtturkce.Size = new System.Drawing.Size(195, 20);
            this.txtturkce.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Türkçe";
            // 
            // txtingilizce
            // 
            this.txtingilizce.Location = new System.Drawing.Point(84, 19);
            this.txtingilizce.Name = "txtingilizce";
            this.txtingilizce.Size = new System.Drawing.Size(135, 20);
            this.txtingilizce.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "İngilizce";
            // 
            // frmAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmAyar";
            this.Text = "frmAyar";
            this.Load += new System.EventHandler(this.frmAyar_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSil;
        internal System.Windows.Forms.Button btnTemizle;
        internal System.Windows.Forms.Button btnGuncelle;
        internal System.Windows.Forms.Button btnAnasayfa;
        internal System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtsonuc;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ListBox lstsonuc;
        internal System.Windows.Forms.TextBox txtturkce;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtingilizce;
        internal System.Windows.Forms.Label Label1;
    }
}