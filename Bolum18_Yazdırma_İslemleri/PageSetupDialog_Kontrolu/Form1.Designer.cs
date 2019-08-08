namespace PageSetupDialog_Kontrolu
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
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaAdı = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnSayfaAyari = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(12, 53);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaSec.TabIndex = 16;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dosya Adı:";
            // 
            // txtDosyaAdı
            // 
            this.txtDosyaAdı.Location = new System.Drawing.Point(73, 12);
            this.txtDosyaAdı.Name = "txtDosyaAdı";
            this.txtDosyaAdı.Size = new System.Drawing.Size(199, 20);
            this.txtDosyaAdı.TabIndex = 18;
            // 
            // btnSayfaAyari
            // 
            this.btnSayfaAyari.Location = new System.Drawing.Point(179, 53);
            this.btnSayfaAyari.Name = "btnSayfaAyari";
            this.btnSayfaAyari.Size = new System.Drawing.Size(93, 23);
            this.btnSayfaAyari.TabIndex = 17;
            this.btnSayfaAyari.Text = "Sayfa Ayarı";
            this.btnSayfaAyari.UseVisualStyleBackColor = true;
            this.btnSayfaAyari.Click += new System.EventHandler(this.btnSayfaAyari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.btnSayfaAyari);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDosyaAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaAdı;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnSayfaAyari;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

