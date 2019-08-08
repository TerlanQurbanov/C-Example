namespace Metod_Overloading
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazılı1 = new System.Windows.Forms.TextBox();
            this.txtYazılı2 = new System.Windows.Forms.TextBox();
            this.txtSozlu = new System.Windows.Forms.TextBox();
            this.txtOdev = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Yazılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Yazılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sözlü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödev";
            // 
            // txtYazılı1
            // 
            this.txtYazılı1.Location = new System.Drawing.Point(68, 12);
            this.txtYazılı1.Name = "txtYazılı1";
            this.txtYazılı1.Size = new System.Drawing.Size(100, 20);
            this.txtYazılı1.TabIndex = 4;
            // 
            // txtYazılı2
            // 
            this.txtYazılı2.Location = new System.Drawing.Point(68, 38);
            this.txtYazılı2.Name = "txtYazılı2";
            this.txtYazılı2.Size = new System.Drawing.Size(100, 20);
            this.txtYazılı2.TabIndex = 5;
            // 
            // txtSozlu
            // 
            this.txtSozlu.Location = new System.Drawing.Point(68, 64);
            this.txtSozlu.Name = "txtSozlu";
            this.txtSozlu.Size = new System.Drawing.Size(100, 20);
            this.txtSozlu.TabIndex = 6;
            // 
            // txtOdev
            // 
            this.txtOdev.Location = new System.Drawing.Point(68, 90);
            this.txtOdev.Name = "txtOdev";
            this.txtOdev.Size = new System.Drawing.Size(100, 20);
            this.txtOdev.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(58, 128);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 158);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtOdev);
            this.Controls.Add(this.txtSozlu);
            this.Controls.Add(this.txtYazılı2);
            this.Controls.Add(this.txtYazılı1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazılı1;
        private System.Windows.Forms.TextBox txtYazılı2;
        private System.Windows.Forms.TextBox txtSozlu;
        private System.Windows.Forms.TextBox txtOdev;
        private System.Windows.Forms.Button btnHesapla;
    }
}

