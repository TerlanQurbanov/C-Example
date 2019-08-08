namespace Property_Faktoriyel
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnislem = new System.Windows.Forms.Button();
            this.lblBasamak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sonuç";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(54, 11);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 2;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(54, 52);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 3;
            // 
            // btnislem
            // 
            this.btnislem.Location = new System.Drawing.Point(45, 113);
            this.btnislem.Name = "btnislem";
            this.btnislem.Size = new System.Drawing.Size(75, 23);
            this.btnislem.TabIndex = 4;
            this.btnislem.Text = "İşlem Yap";
            this.btnislem.UseVisualStyleBackColor = true;
            this.btnislem.Click += new System.EventHandler(this.btnislem_Click);
            // 
            // lblBasamak
            // 
            this.lblBasamak.AutoSize = true;
            this.lblBasamak.Location = new System.Drawing.Point(13, 88);
            this.lblBasamak.Name = "lblBasamak";
            this.lblBasamak.Size = new System.Drawing.Size(0, 13);
            this.lblBasamak.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 144);
            this.Controls.Add(this.lblBasamak);
            this.Controls.Add(this.btnislem);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayi);
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
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnislem;
        private System.Windows.Forms.Label lblBasamak;
    }
}

