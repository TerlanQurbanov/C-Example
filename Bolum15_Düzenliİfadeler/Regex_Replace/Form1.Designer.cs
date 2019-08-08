namespace Regex_Replace
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
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDegistirilecek = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 34);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Değiştirilecek Metin :";
            // 
            // txtDegistirilecek
            // 
            this.txtDegistirilecek.Location = new System.Drawing.Point(120, 31);
            this.txtDegistirilecek.Name = "txtDegistirilecek";
            this.txtDegistirilecek.Size = new System.Drawing.Size(152, 20);
            this.txtDegistirilecek.TabIndex = 20;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 13);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Aranan Metin :";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(120, 5);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(152, 20);
            this.txtAranan.TabIndex = 18;
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(12, 57);
            this.txticerik.Multiline = true;
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(260, 77);
            this.txticerik.TabIndex = 17;
            this.txticerik.Text = "Evet, herşey ya hakikaten güzeldir, ya bizzat güzeldir, veya neticeleri itibarıyl" +
    "a güzeldir.";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(100, 140);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 16;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDegistirilecek);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.btnDegistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDegistirilecek;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAranan;
        internal System.Windows.Forms.TextBox txticerik;
        internal System.Windows.Forms.Button btnDegistir;
    }
}

