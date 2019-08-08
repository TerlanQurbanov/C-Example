namespace Directory_GetDirectories
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnBilgiAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOlusturulmaZamanı = new System.Windows.Forms.TextBox();
            this.txtYazımZamanı = new System.Windows.Forms.TextBox();
            this.txtErisimZamanı = new System.Windows.Forms.TextBox();
            this.txtKlasorAdı = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 37);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(186, 226);
            this.treeView1.TabIndex = 0;
            // 
            // btnBilgiAl
            // 
            this.btnBilgiAl.Location = new System.Drawing.Point(331, 8);
            this.btnBilgiAl.Name = "btnBilgiAl";
            this.btnBilgiAl.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiAl.TabIndex = 2;
            this.btnBilgiAl.Text = "Bilgi Al";
            this.btnBilgiAl.UseVisualStyleBackColor = true;
            this.btnBilgiAl.Click += new System.EventHandler(this.btnBilgiAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klasör Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oluşturulma Zamanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Son Yazım Zamanı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Son Erişim Zamanı";
            // 
            // txtOlusturulmaZamanı
            // 
            this.txtOlusturulmaZamanı.Location = new System.Drawing.Point(112, 13);
            this.txtOlusturulmaZamanı.Name = "txtOlusturulmaZamanı";
            this.txtOlusturulmaZamanı.Size = new System.Drawing.Size(276, 20);
            this.txtOlusturulmaZamanı.TabIndex = 7;
            // 
            // txtYazımZamanı
            // 
            this.txtYazımZamanı.Location = new System.Drawing.Point(112, 40);
            this.txtYazımZamanı.Name = "txtYazımZamanı";
            this.txtYazımZamanı.Size = new System.Drawing.Size(276, 20);
            this.txtYazımZamanı.TabIndex = 8;
            // 
            // txtErisimZamanı
            // 
            this.txtErisimZamanı.Location = new System.Drawing.Point(112, 71);
            this.txtErisimZamanı.Name = "txtErisimZamanı";
            this.txtErisimZamanı.Size = new System.Drawing.Size(276, 20);
            this.txtErisimZamanı.TabIndex = 9;
            // 
            // txtKlasorAdı
            // 
            this.txtKlasorAdı.Location = new System.Drawing.Point(69, 5);
            this.txtKlasorAdı.Name = "txtKlasorAdı";
            this.txtKlasorAdı.Size = new System.Drawing.Size(228, 20);
            this.txtKlasorAdı.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtErisimZamanı);
            this.groupBox1.Controls.Add(this.txtOlusturulmaZamanı);
            this.groupBox1.Controls.Add(this.txtYazımZamanı);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(213, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 225);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 375);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKlasorAdı);
            this.Controls.Add(this.btnBilgiAl);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnBilgiAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOlusturulmaZamanı;
        private System.Windows.Forms.TextBox txtYazımZamanı;
        private System.Windows.Forms.TextBox txtErisimZamanı;
        private System.Windows.Forms.TextBox txtKlasorAdı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

