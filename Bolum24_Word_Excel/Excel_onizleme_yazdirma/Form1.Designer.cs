namespace Excel_onizleme_yazdirma
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
            this.btn_yaziaktar = new System.Windows.Forms.Button();
            this.btn_baskı_onizleme = new System.Windows.Forms.Button();
            this.btn_yazdır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yaziaktar
            // 
            this.btn_yaziaktar.Location = new System.Drawing.Point(2, 227);
            this.btn_yaziaktar.Name = "btn_yaziaktar";
            this.btn_yaziaktar.Size = new System.Drawing.Size(75, 23);
            this.btn_yaziaktar.TabIndex = 0;
            this.btn_yaziaktar.Text = "Yazı Aktar";
            this.btn_yaziaktar.UseVisualStyleBackColor = true;
            this.btn_yaziaktar.Click += new System.EventHandler(this.btn_yaziaktar_Click);
            // 
            // btn_baskı_onizleme
            // 
            this.btn_baskı_onizleme.Location = new System.Drawing.Point(93, 227);
            this.btn_baskı_onizleme.Name = "btn_baskı_onizleme";
            this.btn_baskı_onizleme.Size = new System.Drawing.Size(89, 23);
            this.btn_baskı_onizleme.TabIndex = 1;
            this.btn_baskı_onizleme.Text = "Baskı Önizleme";
            this.btn_baskı_onizleme.UseVisualStyleBackColor = true;
            this.btn_baskı_onizleme.Click += new System.EventHandler(this.btn_baskı_onizleme_Click);
            // 
            // btn_yazdır
            // 
            this.btn_yazdır.Location = new System.Drawing.Point(198, 227);
            this.btn_yazdır.Name = "btn_yazdır";
            this.btn_yazdır.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdır.TabIndex = 2;
            this.btn_yazdır.Text = "Yazdır";
            this.btn_yazdır.UseVisualStyleBackColor = true;
            this.btn_yazdır.Click += new System.EventHandler(this.btn_yazdır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_yazdır);
            this.Controls.Add(this.btn_baskı_onizleme);
            this.Controls.Add(this.btn_yaziaktar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yaziaktar;
        private System.Windows.Forms.Button btn_baskı_onizleme;
        private System.Windows.Forms.Button btn_yazdır;
    }
}

