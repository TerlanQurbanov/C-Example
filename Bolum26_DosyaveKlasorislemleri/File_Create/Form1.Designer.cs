namespace File_Create
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
            this.btnDosyayaYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDosyayaYaz
            // 
            this.btnDosyayaYaz.Location = new System.Drawing.Point(100, 227);
            this.btnDosyayaYaz.Name = "btnDosyayaYaz";
            this.btnDosyayaYaz.Size = new System.Drawing.Size(90, 23);
            this.btnDosyayaYaz.TabIndex = 0;
            this.btnDosyayaYaz.Text = "Dosyaya Yaz";
            this.btnDosyayaYaz.UseVisualStyleBackColor = true;
            this.btnDosyayaYaz.Click += new System.EventHandler(this.btnDosyayaYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDosyayaYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDosyayaYaz;
    }
}

