namespace word_belge_acma
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
            this.btnYeniBelge = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniBelge
            // 
            this.btnYeniBelge.Location = new System.Drawing.Point(12, 227);
            this.btnYeniBelge.Name = "btnYeniBelge";
            this.btnYeniBelge.Size = new System.Drawing.Size(75, 23);
            this.btnYeniBelge.TabIndex = 0;
            this.btnYeniBelge.Text = "Yeni Belge";
            this.btnYeniBelge.UseVisualStyleBackColor = true;
            this.btnYeniBelge.Click += new System.EventHandler(this.btnYeniBelge_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(180, 227);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYeniBelge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniBelge;
        private System.Windows.Forms.Button btnKapat;
    }
}

