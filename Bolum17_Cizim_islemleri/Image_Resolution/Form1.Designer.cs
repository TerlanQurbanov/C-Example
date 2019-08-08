namespace Image_Resolution
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.lblGenislikYukseklik = new System.Windows.Forms.Label();
            this.lblCozunurluk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(102, 277);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Resim Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lblGenislikYukseklik
            // 
            this.lblGenislikYukseklik.AutoSize = true;
            this.lblGenislikYukseklik.Location = new System.Drawing.Point(12, 233);
            this.lblGenislikYukseklik.Name = "lblGenislikYukseklik";
            this.lblGenislikYukseklik.Size = new System.Drawing.Size(16, 13);
            this.lblGenislikYukseklik.TabIndex = 4;
            this.lblGenislikYukseklik.Text = "...";
            // 
            // lblCozunurluk
            // 
            this.lblCozunurluk.AutoSize = true;
            this.lblCozunurluk.Location = new System.Drawing.Point(12, 257);
            this.lblCozunurluk.Name = "lblCozunurluk";
            this.lblCozunurluk.Size = new System.Drawing.Size(16, 13);
            this.lblCozunurluk.TabIndex = 5;
            this.lblCozunurluk.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.Controls.Add(this.lblCozunurluk);
            this.Controls.Add(this.lblGenislikYukseklik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSec);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label lblGenislikYukseklik;
        private System.Windows.Forms.Label lblCozunurluk;
    }
}

