namespace TimeSpan_TarihFark
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
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.btnFark = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Tarih Değeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Tarih Değeri";
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(96, 12);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.Size = new System.Drawing.Size(100, 20);
            this.txtTarih1.TabIndex = 2;
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(96, 48);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.Size = new System.Drawing.Size(100, 20);
            this.txtTarih2.TabIndex = 3;
            // 
            // btnFark
            // 
            this.btnFark.Location = new System.Drawing.Point(96, 84);
            this.btnFark.Name = "btnFark";
            this.btnFark.Size = new System.Drawing.Size(100, 23);
            this.btnFark.TabIndex = 4;
            this.btnFark.Text = "Fark";
            this.btnFark.UseVisualStyleBackColor = true;
            this.btnFark.Click += new System.EventHandler(this.btnFark_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(12, 94);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(16, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 119);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnFark);
            this.Controls.Add(this.txtTarih2);
            this.Controls.Add(this.txtTarih1);
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
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.TextBox txtTarih2;
        private System.Windows.Forms.Button btnFark;
        private System.Windows.Forms.Label lblSonuc;
    }
}

