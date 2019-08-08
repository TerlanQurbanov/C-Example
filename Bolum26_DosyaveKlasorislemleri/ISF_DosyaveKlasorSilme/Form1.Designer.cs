namespace ISF_DosyaveKlasorSilme
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
            this.lstKlasor = new System.Windows.Forms.ListBox();
            this.lstDosya = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKlasor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDosyaOlustur = new System.Windows.Forms.Button();
            this.btnKlasorSil = new System.Windows.Forms.Button();
            this.btnDosyaSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKlasor
            // 
            this.lstKlasor.FormattingEnabled = true;
            this.lstKlasor.Location = new System.Drawing.Point(12, 12);
            this.lstKlasor.Name = "lstKlasor";
            this.lstKlasor.Size = new System.Drawing.Size(177, 160);
            this.lstKlasor.TabIndex = 0;
            this.lstKlasor.SelectedIndexChanged += new System.EventHandler(this.lstKlasor_SelectedIndexChanged);
            // 
            // lstDosya
            // 
            this.lstDosya.FormattingEnabled = true;
            this.lstDosya.Location = new System.Drawing.Point(207, 12);
            this.lstDosya.Name = "lstDosya";
            this.lstDosya.Size = new System.Drawing.Size(177, 160);
            this.lstDosya.TabIndex = 1;
            this.lstDosya.SelectedIndexChanged += new System.EventHandler(this.lstDosya_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txticerik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDosya);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKlasor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDosyaOlustur);
            this.groupBox1.Location = new System.Drawing.Point(399, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Klasör ve Dosya Oluştur";
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(69, 85);
            this.txticerik.Multiline = true;
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(148, 65);
            this.txticerik.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "İçerik";
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(69, 50);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(148, 20);
            this.txtDosya.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dosya Adı";
            // 
            // txtKlasor
            // 
            this.txtKlasor.Location = new System.Drawing.Point(69, 19);
            this.txtKlasor.Name = "txtKlasor";
            this.txtKlasor.Size = new System.Drawing.Size(148, 20);
            this.txtKlasor.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Klasör Adı";
            // 
            // btnDosyaOlustur
            // 
            this.btnDosyaOlustur.Location = new System.Drawing.Point(69, 168);
            this.btnDosyaOlustur.Name = "btnDosyaOlustur";
            this.btnDosyaOlustur.Size = new System.Drawing.Size(124, 23);
            this.btnDosyaOlustur.TabIndex = 15;
            this.btnDosyaOlustur.Text = " Yeni Dosya Oluştur";
            this.btnDosyaOlustur.UseVisualStyleBackColor = true;
            this.btnDosyaOlustur.Click += new System.EventHandler(this.btnDosyaOlustur_Click);
            // 
            // btnKlasorSil
            // 
            this.btnKlasorSil.Location = new System.Drawing.Point(47, 180);
            this.btnKlasorSil.Name = "btnKlasorSil";
            this.btnKlasorSil.Size = new System.Drawing.Size(124, 23);
            this.btnKlasorSil.TabIndex = 16;
            this.btnKlasorSil.Text = "Klasör Sil";
            this.btnKlasorSil.UseVisualStyleBackColor = true;
            this.btnKlasorSil.Click += new System.EventHandler(this.btnKlasorSil_Click);
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Location = new System.Drawing.Point(240, 180);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(124, 23);
            this.btnDosyaSil.TabIndex = 17;
            this.btnDosyaSil.Text = "Dosya Sil";
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 220);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(615, 71);
            this.textBox1.TabIndex = 18;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(258, 297);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(106, 23);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 327);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDosyaSil);
            this.Controls.Add(this.btnKlasorSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstDosya);
            this.Controls.Add(this.lstKlasor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKlasor;
        private System.Windows.Forms.ListBox lstDosya;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txticerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKlasor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDosyaOlustur;
        private System.Windows.Forms.Button btnKlasorSil;
        private System.Windows.Forms.Button btnDosyaSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnListele;
    }
}

