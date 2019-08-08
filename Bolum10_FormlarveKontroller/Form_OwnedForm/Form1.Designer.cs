namespace Form_OwnedForm
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
            this.btnOwnedFormEkle = new System.Windows.Forms.Button();
            this.btnOwnedFormSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOwnedFormEkle
            // 
            this.btnOwnedFormEkle.Location = new System.Drawing.Point(11, 271);
            this.btnOwnedFormEkle.Name = "btnOwnedFormEkle";
            this.btnOwnedFormEkle.Size = new System.Drawing.Size(120, 23);
            this.btnOwnedFormEkle.TabIndex = 0;
            this.btnOwnedFormEkle.Text = "Owned Form Oluştur";
            this.btnOwnedFormEkle.UseVisualStyleBackColor = true;
            this.btnOwnedFormEkle.Click += new System.EventHandler(this.btnOwnedFormEkle_Click);
            // 
            // btnOwnedFormSil
            // 
            this.btnOwnedFormSil.Location = new System.Drawing.Point(184, 271);
            this.btnOwnedFormSil.Name = "btnOwnedFormSil";
            this.btnOwnedFormSil.Size = new System.Drawing.Size(120, 23);
            this.btnOwnedFormSil.TabIndex = 1;
            this.btnOwnedFormSil.Text = "Owned Form\'u Sil";
            this.btnOwnedFormSil.UseVisualStyleBackColor = true;
            this.btnOwnedFormSil.Click += new System.EventHandler(this.btnOwnedFormSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 306);
            this.Controls.Add(this.btnOwnedFormSil);
            this.Controls.Add(this.btnOwnedFormEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOwnedFormEkle;
        private System.Windows.Forms.Button btnOwnedFormSil;
    }
}

