namespace Regex_Matches_Count
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtaranan = new System.Windows.Forms.TextBox();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Aranan Metin :";
            // 
            // txtaranan
            // 
            this.txtaranan.Location = new System.Drawing.Point(91, 12);
            this.txtaranan.Name = "txtaranan";
            this.txtaranan.Size = new System.Drawing.Size(181, 20);
            this.txtaranan.TabIndex = 10;
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(12, 38);
            this.txticerik.Multiline = true;
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(260, 58);
            this.txticerik.TabIndex = 9;
            this.txticerik.Text = "Evet, herşey ya hakikaten güzeldir, ya bizzat güzeldir, veya neticeleri itibarıyl" +
    "a güzeldir.";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(100, 102);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtaranan);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.btnBul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtaranan;
        internal System.Windows.Forms.TextBox txticerik;
        internal System.Windows.Forms.Button btnBul;
    }
}

