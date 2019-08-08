namespace Set_Value
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
            this.btnDegerOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegerOlustur
            // 
            this.btnDegerOlustur.Location = new System.Drawing.Point(22, 90);
            this.btnDegerOlustur.Name = "btnDegerOlustur";
            this.btnDegerOlustur.Size = new System.Drawing.Size(103, 23);
            this.btnDegerOlustur.TabIndex = 0;
            this.btnDegerOlustur.Text = "Değer Oluştur";
            this.btnDegerOlustur.UseVisualStyleBackColor = true;
            this.btnDegerOlustur.Click += new System.EventHandler(this.btnDegerOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 119);
            this.Controls.Add(this.btnDegerOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDegerOlustur;
    }
}

