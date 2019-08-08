namespace word_onizleme_yazdirma
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
            this.btnyaziekle = new System.Windows.Forms.Button();
            this.btn_baski_onizleme = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnyaziekle
            // 
            this.btnyaziekle.Location = new System.Drawing.Point(8, 177);
            this.btnyaziekle.Name = "btnyaziekle";
            this.btnyaziekle.Size = new System.Drawing.Size(75, 23);
            this.btnyaziekle.TabIndex = 0;
            this.btnyaziekle.Text = "Yazı Ekle";
            this.btnyaziekle.UseVisualStyleBackColor = true;
            this.btnyaziekle.Click += new System.EventHandler(this.btnyaziekle_Click);
            // 
            // btn_baski_onizleme
            // 
            this.btn_baski_onizleme.Location = new System.Drawing.Point(89, 177);
            this.btn_baski_onizleme.Name = "btn_baski_onizleme";
            this.btn_baski_onizleme.Size = new System.Drawing.Size(88, 23);
            this.btn_baski_onizleme.TabIndex = 1;
            this.btn_baski_onizleme.Text = "Baskı Önizleme";
            this.btn_baski_onizleme.UseVisualStyleBackColor = true;
            this.btn_baski_onizleme.Click += new System.EventHandler(this.btn_baski_onizleme_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(183, 177);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 2;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(264, 177);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 23);
            this.btnkapat.TabIndex = 3;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 150);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Azmine Sarıl\r\n\r\nYe\'s öyle bir bataktır ki,\r\nDüşersen boğulursun.\r\nAzmine sarıl sı" +
    "msıkı.\r\nBak ne olursun.\r\n\r\nMehmet Akif ERSOY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 209);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.btn_baski_onizleme);
            this.Controls.Add(this.btnyaziekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyaziekle;
        private System.Windows.Forms.Button btn_baski_onizleme;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.TextBox textBox1;
    }
}

