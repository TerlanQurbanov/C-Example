namespace DosyaOzellikleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOlusturulmaZamanı = new System.Windows.Forms.TextBox();
            this.txtYazımZamanı = new System.Windows.Forms.TextBox();
            this.txtErisimZamanı = new System.Windows.Forms.TextBox();
            this.btnBilgiAl = new System.Windows.Forms.Button();
            this.btnBilgiDegistir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBilgiDegistir);
            this.groupBox1.Controls.Add(this.btnBilgiAl);
            this.groupBox1.Controls.Add(this.txtErisimZamanı);
            this.groupBox1.Controls.Add(this.txtYazımZamanı);
            this.groupBox1.Controls.Add(this.txtOlusturulmaZamanı);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Özellikleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oluşturulma Zamanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Son Yazım Zamanı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Son Erişim Zamanı";
            // 
            // txtOlusturulmaZamanı
            // 
            this.txtOlusturulmaZamanı.Location = new System.Drawing.Point(112, 20);
            this.txtOlusturulmaZamanı.Name = "txtOlusturulmaZamanı";
            this.txtOlusturulmaZamanı.Size = new System.Drawing.Size(131, 20);
            this.txtOlusturulmaZamanı.TabIndex = 3;
            // 
            // txtYazımZamanı
            // 
            this.txtYazımZamanı.Location = new System.Drawing.Point(112, 55);
            this.txtYazımZamanı.Name = "txtYazımZamanı";
            this.txtYazımZamanı.Size = new System.Drawing.Size(131, 20);
            this.txtYazımZamanı.TabIndex = 4;
            // 
            // txtErisimZamanı
            // 
            this.txtErisimZamanı.Location = new System.Drawing.Point(112, 91);
            this.txtErisimZamanı.Name = "txtErisimZamanı";
            this.txtErisimZamanı.Size = new System.Drawing.Size(131, 20);
            this.txtErisimZamanı.TabIndex = 5;
            // 
            // btnBilgiAl
            // 
            this.btnBilgiAl.Location = new System.Drawing.Point(9, 127);
            this.btnBilgiAl.Name = "btnBilgiAl";
            this.btnBilgiAl.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiAl.TabIndex = 6;
            this.btnBilgiAl.Text = "Bilgi Al";
            this.btnBilgiAl.UseVisualStyleBackColor = true;
            this.btnBilgiAl.Click += new System.EventHandler(this.btnBilgiAl_Click);
            // 
            // btnBilgiDegistir
            // 
            this.btnBilgiDegistir.Location = new System.Drawing.Point(154, 127);
            this.btnBilgiDegistir.Name = "btnBilgiDegistir";
            this.btnBilgiDegistir.Size = new System.Drawing.Size(89, 23);
            this.btnBilgiDegistir.TabIndex = 7;
            this.btnBilgiDegistir.Text = "Bilgileri Değiştir";
            this.btnBilgiDegistir.UseVisualStyleBackColor = true;
            this.btnBilgiDegistir.Click += new System.EventHandler(this.btnBilgiDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBilgiDegistir;
        private System.Windows.Forms.Button btnBilgiAl;
        private System.Windows.Forms.TextBox txtErisimZamanı;
        private System.Windows.Forms.TextBox txtYazımZamanı;
        private System.Windows.Forms.TextBox txtOlusturulmaZamanı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

