namespace Api_SHQueryRecycleBin
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.btnBilgiAl = new System.Windows.Forms.Button();
            this.btnBosalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(12, 9);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(185, 13);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "Geri dönüşüm kutusundaki öğe sayısı:";
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Location = new System.Drawing.Point(12, 44);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(211, 13);
            this.lblBoyut.TabIndex = 1;
            this.lblBoyut.Text = "Geri dönüşüm kutusundaki öğelerin boyutu:";
            // 
            // btnBilgiAl
            // 
            this.btnBilgiAl.Location = new System.Drawing.Point(15, 88);
            this.btnBilgiAl.Name = "btnBilgiAl";
            this.btnBilgiAl.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiAl.TabIndex = 2;
            this.btnBilgiAl.Text = "Bilgi Al";
            this.btnBilgiAl.UseVisualStyleBackColor = true;
            this.btnBilgiAl.Click += new System.EventHandler(this.btnBilgiAl_Click);
            // 
            // btnBosalt
            // 
            this.btnBosalt.Location = new System.Drawing.Point(190, 88);
            this.btnBosalt.Name = "btnBosalt";
            this.btnBosalt.Size = new System.Drawing.Size(75, 23);
            this.btnBosalt.TabIndex = 3;
            this.btnBosalt.Text = "Boşalt";
            this.btnBosalt.UseVisualStyleBackColor = true;
            this.btnBosalt.Click += new System.EventHandler(this.btnBosalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 123);
            this.Controls.Add(this.btnBosalt);
            this.Controls.Add(this.btnBilgiAl);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.lblSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.Button btnBilgiAl;
        private System.Windows.Forms.Button btnBosalt;
    }
}

