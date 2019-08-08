namespace Api_GetDiskFreeSpaceExA
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
            this.btnBilgiAl = new System.Windows.Forms.Button();
            this.lblDiskAdı = new System.Windows.Forms.Label();
            this.lblToplamAlan = new System.Windows.Forms.Label();
            this.lblBosAlan = new System.Windows.Forms.Label();
            this.txtDiskAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBilgiAl
            // 
            this.btnBilgiAl.Location = new System.Drawing.Point(55, 105);
            this.btnBilgiAl.Name = "btnBilgiAl";
            this.btnBilgiAl.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiAl.TabIndex = 0;
            this.btnBilgiAl.Text = "Bilgi Al";
            this.btnBilgiAl.UseVisualStyleBackColor = true;
            this.btnBilgiAl.Click += new System.EventHandler(this.btnBilgiAl_Click);
            // 
            // lblDiskAdı
            // 
            this.lblDiskAdı.AutoSize = true;
            this.lblDiskAdı.Location = new System.Drawing.Point(10, 19);
            this.lblDiskAdı.Name = "lblDiskAdı";
            this.lblDiskAdı.Size = new System.Drawing.Size(49, 13);
            this.lblDiskAdı.TabIndex = 1;
            this.lblDiskAdı.Text = "Disk Adı:";
            // 
            // lblToplamAlan
            // 
            this.lblToplamAlan.AutoSize = true;
            this.lblToplamAlan.Location = new System.Drawing.Point(10, 48);
            this.lblToplamAlan.Name = "lblToplamAlan";
            this.lblToplamAlan.Size = new System.Drawing.Size(64, 13);
            this.lblToplamAlan.TabIndex = 2;
            this.lblToplamAlan.Text = "Disk Boyutu";
            // 
            // lblBosAlan
            // 
            this.lblBosAlan.AutoSize = true;
            this.lblBosAlan.Location = new System.Drawing.Point(10, 81);
            this.lblBosAlan.Name = "lblBosAlan";
            this.lblBosAlan.Size = new System.Drawing.Size(83, 13);
            this.lblBosAlan.TabIndex = 3;
            this.lblBosAlan.Text = "Boş Alan Miktarı";
            // 
            // txtDiskAdi
            // 
            this.txtDiskAdi.Location = new System.Drawing.Point(65, 12);
            this.txtDiskAdi.Name = "txtDiskAdi";
            this.txtDiskAdi.Size = new System.Drawing.Size(51, 20);
            this.txtDiskAdi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 140);
            this.Controls.Add(this.txtDiskAdi);
            this.Controls.Add(this.lblBosAlan);
            this.Controls.Add(this.lblToplamAlan);
            this.Controls.Add(this.lblDiskAdı);
            this.Controls.Add(this.btnBilgiAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiAl;
        private System.Windows.Forms.Label lblDiskAdı;
        private System.Windows.Forms.Label lblToplamAlan;
        private System.Windows.Forms.Label lblBosAlan;
        private System.Windows.Forms.TextBox txtDiskAdi;
    }
}

