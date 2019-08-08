namespace word_grafik
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
            this.lstisim = new System.Windows.Forms.ListBox();
            this.lstyas = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstisim
            // 
            this.lstisim.FormattingEnabled = true;
            this.lstisim.Items.AddRange(new object[] {
            "Talha",
            "Sümeyye",
            "Azra",
            "Murat"});
            this.lstisim.Location = new System.Drawing.Point(12, 12);
            this.lstisim.Name = "lstisim";
            this.lstisim.Size = new System.Drawing.Size(120, 95);
            this.lstisim.TabIndex = 0;
            // 
            // lstyas
            // 
            this.lstyas.FormattingEnabled = true;
            this.lstyas.Items.AddRange(new object[] {
            "10",
            "7",
            "4",
            "17"});
            this.lstyas.Location = new System.Drawing.Point(138, 12);
            this.lstyas.Name = "lstyas";
            this.lstyas.Size = new System.Drawing.Size(120, 95);
            this.lstyas.TabIndex = 1;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(95, 117);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 23);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 146);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lstyas);
            this.Controls.Add(this.lstisim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstisim;
        private System.Windows.Forms.ListBox lstyas;
        private System.Windows.Forms.Button btnAktar;
    }
}

