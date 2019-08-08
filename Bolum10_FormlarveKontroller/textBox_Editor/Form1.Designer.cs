namespace textBox_Editor
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
            this.btnAltiCizili = new System.Windows.Forms.Button();
            this.btnEgik = new System.Windows.Forms.Button();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnKalin = new System.Windows.Forms.Button();
            this.btnYaziRengi = new System.Windows.Forms.Button();
            this.btnYaziTipi = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAltiCizili
            // 
            this.btnAltiCizili.Location = new System.Drawing.Point(375, 128);
            this.btnAltiCizili.Name = "btnAltiCizili";
            this.btnAltiCizili.Size = new System.Drawing.Size(75, 23);
            this.btnAltiCizili.TabIndex = 34;
            this.btnAltiCizili.Text = "Altı Çizili";
            this.btnAltiCizili.UseVisualStyleBackColor = true;
            this.btnAltiCizili.Click += new System.EventHandler(this.btnAltiCizili_Click);
            // 
            // btnEgik
            // 
            this.btnEgik.Location = new System.Drawing.Point(375, 99);
            this.btnEgik.Name = "btnEgik";
            this.btnEgik.Size = new System.Drawing.Size(75, 23);
            this.btnEgik.TabIndex = 33;
            this.btnEgik.Text = "Eğik";
            this.btnEgik.UseVisualStyleBackColor = true;
            this.btnEgik.Click += new System.EventHandler(this.btnEgik_Click);
            // 
            // FontDialog1
            // 
            this.FontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // btnKalin
            // 
            this.btnKalin.Location = new System.Drawing.Point(375, 70);
            this.btnKalin.Name = "btnKalin";
            this.btnKalin.Size = new System.Drawing.Size(75, 23);
            this.btnKalin.TabIndex = 32;
            this.btnKalin.Text = "Kalın";
            this.btnKalin.UseVisualStyleBackColor = true;
            this.btnKalin.Click += new System.EventHandler(this.btnKalin_Click);
            // 
            // btnYaziRengi
            // 
            this.btnYaziRengi.Location = new System.Drawing.Point(375, 41);
            this.btnYaziRengi.Name = "btnYaziRengi";
            this.btnYaziRengi.Size = new System.Drawing.Size(75, 23);
            this.btnYaziRengi.TabIndex = 31;
            this.btnYaziRengi.Text = "Yazı Rengi";
            this.btnYaziRengi.UseVisualStyleBackColor = true;
            this.btnYaziRengi.Click += new System.EventHandler(this.btnYaziRengi_Click);
            // 
            // btnYaziTipi
            // 
            this.btnYaziTipi.Location = new System.Drawing.Point(375, 12);
            this.btnYaziTipi.Name = "btnYaziTipi";
            this.btnYaziTipi.Size = new System.Drawing.Size(75, 23);
            this.btnYaziTipi.TabIndex = 30;
            this.btnYaziTipi.Text = "Yazı Tipi";
            this.btnYaziTipi.UseVisualStyleBackColor = true;
            this.btnYaziTipi.Click += new System.EventHandler(this.btnYaziTipi_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(294, 166);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(75, 23);
            this.btnGeriAl.TabIndex = 29;
            this.btnGeriAl.Text = "GeriAl";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(202, 166);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(75, 23);
            this.btnYapistir.TabIndex = 28;
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(103, 166);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 23);
            this.btnKopyala.TabIndex = 27;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(12, 166);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(75, 23);
            this.btnKes.TabIndex = 26;
            this.btnKes.Text = "Kes";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 139);
            this.textBox1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 201);
            this.Controls.Add(this.btnAltiCizili);
            this.Controls.Add(this.btnEgik);
            this.Controls.Add(this.btnKalin);
            this.Controls.Add(this.btnYaziRengi);
            this.Controls.Add(this.btnYaziTipi);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAltiCizili;
        internal System.Windows.Forms.Button btnEgik;
        internal System.Windows.Forms.FontDialog FontDialog1;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.Button btnKalin;
        internal System.Windows.Forms.Button btnYaziRengi;
        internal System.Windows.Forms.Button btnYaziTipi;
        internal System.Windows.Forms.Button btnGeriAl;
        internal System.Windows.Forms.Button btnYapistir;
        internal System.Windows.Forms.Button btnKopyala;
        internal System.Windows.Forms.Button btnKes;
        internal System.Windows.Forms.TextBox textBox1;
    }
}

