namespace printpreviewdialog_kontrol_form_uzerinde
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosyaAdı = new System.Windows.Forms.TextBox();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(375, 385);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(93, 23);
            this.btnBaskiOnizleme.TabIndex = 17;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = true;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(283, 384);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaSec.TabIndex = 16;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dosya Adı:";
            // 
            // txtDosyaAdı
            // 
            this.txtDosyaAdı.Location = new System.Drawing.Point(78, 387);
            this.txtDosyaAdı.Name = "txtDosyaAdı";
            this.txtDosyaAdı.Size = new System.Drawing.Size(199, 20);
            this.txtDosyaAdı.TabIndex = 18;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(17, 12);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(446, 366);
            this.printPreviewControl1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 419);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.btnBaskiOnizleme);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDosyaAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
                
        private System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosyaAdı;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}

