namespace Excel_grafik
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
            this.btnAktar = new System.Windows.Forms.Button();
            this.lstisim = new System.Windows.Forms.ListBox();
            this.lstyas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(99, 137);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 23);
            this.btnAktar.TabIndex = 0;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lstisim
            // 
            this.lstisim.FormattingEnabled = true;
            this.lstisim.Items.AddRange(new object[] {
            "Talha",
            "Sümeyye",
            "Azra",
            "Mehmet",
            "Hüma",
            "Murat"});
            this.lstisim.Location = new System.Drawing.Point(12, 26);
            this.lstisim.Name = "lstisim";
            this.lstisim.Size = new System.Drawing.Size(120, 95);
            this.lstisim.TabIndex = 1;
            // 
            // lstyas
            // 
            this.lstyas.FormattingEnabled = true;
            this.lstyas.Items.AddRange(new object[] {
            "10",
            "7",
            "4",
            "19",
            "2",
            "17"});
            this.lstyas.Location = new System.Drawing.Point(152, 26);
            this.lstyas.Name = "lstyas";
            this.lstyas.Size = new System.Drawing.Size(120, 95);
            this.lstyas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yaş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstyas);
            this.Controls.Add(this.lstisim);
            this.Controls.Add(this.btnAktar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lstisim;
        private System.Windows.Forms.ListBox lstyas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

