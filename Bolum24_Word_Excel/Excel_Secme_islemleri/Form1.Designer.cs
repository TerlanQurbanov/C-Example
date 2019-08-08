namespace Excel_Secme_islemleri
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
            this.btnSatirSec = new System.Windows.Forms.Button();
            this.btnSutunSec = new System.Windows.Forms.Button();
            this.btnHucreSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSatirSec
            // 
            this.btnSatirSec.Location = new System.Drawing.Point(12, 227);
            this.btnSatirSec.Name = "btnSatirSec";
            this.btnSatirSec.Size = new System.Drawing.Size(75, 23);
            this.btnSatirSec.TabIndex = 0;
            this.btnSatirSec.Text = "Satır Seç";
            this.btnSatirSec.UseVisualStyleBackColor = true;
            this.btnSatirSec.Click += new System.EventHandler(this.btnSatirSec_Click);
            // 
            // btnSutunSec
            // 
            this.btnSutunSec.Location = new System.Drawing.Point(104, 227);
            this.btnSutunSec.Name = "btnSutunSec";
            this.btnSutunSec.Size = new System.Drawing.Size(75, 23);
            this.btnSutunSec.TabIndex = 1;
            this.btnSutunSec.Text = "Sütun Seç";
            this.btnSutunSec.UseVisualStyleBackColor = true;
            this.btnSutunSec.Click += new System.EventHandler(this.btnSutunSec_Click);
            // 
            // btnHucreSec
            // 
            this.btnHucreSec.Location = new System.Drawing.Point(197, 227);
            this.btnHucreSec.Name = "btnHucreSec";
            this.btnHucreSec.Size = new System.Drawing.Size(75, 23);
            this.btnHucreSec.TabIndex = 2;
            this.btnHucreSec.Text = "Hücre Seç";
            this.btnHucreSec.UseVisualStyleBackColor = true;
            this.btnHucreSec.Click += new System.EventHandler(this.btnHucreSec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnHucreSec);
            this.Controls.Add(this.btnSutunSec);
            this.Controls.Add(this.btnSatirSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSatirSec;
        private System.Windows.Forms.Button btnSutunSec;
        private System.Windows.Forms.Button btnHucreSec;
    }
}

