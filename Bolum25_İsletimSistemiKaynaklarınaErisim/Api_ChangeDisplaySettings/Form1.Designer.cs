namespace Api_ChangeDisplaySettings
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCozunurlukBul = new System.Windows.Forms.Button();
            this.btnCozunurlukDegistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAktifCozunurluk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnCozunurlukBul
            // 
            this.btnCozunurlukBul.Location = new System.Drawing.Point(11, 253);
            this.btnCozunurlukBul.Name = "btnCozunurlukBul";
            this.btnCozunurlukBul.Size = new System.Drawing.Size(92, 23);
            this.btnCozunurlukBul.TabIndex = 1;
            this.btnCozunurlukBul.Text = "Çözünürlüğü Bul";
            this.btnCozunurlukBul.UseVisualStyleBackColor = true;
            this.btnCozunurlukBul.Click += new System.EventHandler(this.btnCozunurlukBul_Click);
            // 
            // btnCozunurlukDegistir
            // 
            this.btnCozunurlukDegistir.Location = new System.Drawing.Point(184, 253);
            this.btnCozunurlukDegistir.Name = "btnCozunurlukDegistir";
            this.btnCozunurlukDegistir.Size = new System.Drawing.Size(115, 23);
            this.btnCozunurlukDegistir.TabIndex = 2;
            this.btnCozunurlukDegistir.Text = "Çözünürlüğü Değiştir";
            this.btnCozunurlukDegistir.UseVisualStyleBackColor = true;
            this.btnCozunurlukDegistir.Click += new System.EventHandler(this.btnCozunurlukDegistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desteklenen Çözünürlükler";
            // 
            // lblAktifCozunurluk
            // 
            this.lblAktifCozunurluk.AutoSize = true;
            this.lblAktifCozunurluk.Location = new System.Drawing.Point(12, 227);
            this.lblAktifCozunurluk.Name = "lblAktifCozunurluk";
            this.lblAktifCozunurluk.Size = new System.Drawing.Size(16, 13);
            this.lblAktifCozunurluk.TabIndex = 4;
            this.lblAktifCozunurluk.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 282);
            this.Controls.Add(this.lblAktifCozunurluk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCozunurlukDegistir);
            this.Controls.Add(this.btnCozunurlukBul);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCozunurlukBul;
        private System.Windows.Forms.Button btnCozunurlukDegistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAktifCozunurluk;
    }
}

