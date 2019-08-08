namespace Klasor_Kopyala_Tası__DirectoryNesnesi_
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
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.txtHedef = new System.Windows.Forms.TextBox();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnTası = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaynak Klasör Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hedef Klasör Adı";
            // 
            // txtKaynak
            // 
            this.txtKaynak.Location = new System.Drawing.Point(104, 9);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(168, 20);
            this.txtKaynak.TabIndex = 2;
            // 
            // txtHedef
            // 
            this.txtHedef.Location = new System.Drawing.Point(104, 44);
            this.txtHedef.Name = "txtHedef";
            this.txtHedef.Size = new System.Drawing.Size(168, 20);
            this.txtHedef.TabIndex = 3;
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(15, 73);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 23);
            this.btnKopyala.TabIndex = 4;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnTası
            // 
            this.btnTası.Location = new System.Drawing.Point(197, 73);
            this.btnTası.Name = "btnTası";
            this.btnTası.Size = new System.Drawing.Size(75, 23);
            this.btnTası.TabIndex = 5;
            this.btnTası.Text = "Taşı";
            this.btnTası.UseVisualStyleBackColor = true;
            this.btnTası.Click += new System.EventHandler(this.btnTası_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnTası);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.txtHedef);
            this.Controls.Add(this.txtKaynak);
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
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.TextBox txtHedef;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnTası;
    }
}

