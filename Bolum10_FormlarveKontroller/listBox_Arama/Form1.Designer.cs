﻿namespace listBox_Arama
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.Arama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(65, 6);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(154, 20);
            this.txtAranan.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 186);
            this.listBox1.TabIndex = 2;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(15, 233);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 23);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(144, 233);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(75, 23);
            this.Arama.TabIndex = 4;
            this.Arama.Text = "Arama";
            this.Arama.UseVisualStyleBackColor = true;
            this.Arama.Click += new System.EventHandler(this.Arama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 262);
            this.Controls.Add(this.Arama);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button Arama;
    }
}
