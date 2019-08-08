namespace regex_rakamsayı_kontrol
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
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(88, 122);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(168, 20);
            this.txtTCKimlik.TabIndex = 23;
            this.txtTCKimlik.Leave += new System.EventHandler(this.txtTCKimlik_Leave);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 125);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(77, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "T.C. Kimlik No:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(88, 87);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(168, 20);
            this.txtTelefon.TabIndex = 21;
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Telefonu:";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(88, 49);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(168, 20);
            this.txtNumara.TabIndex = 19;
            this.txtNumara.Leave += new System.EventHandler(this.txtNumara_Leave);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 13);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Numarası:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(88, 12);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(168, 20);
            this.txtAdSoyad.TabIndex = 17;
            this.txtAdSoyad.Leave += new System.EventHandler(this.txtAdSoyad_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Ad Soyad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 153);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTCKimlik;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtTelefon;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNumara;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtAdSoyad;
        internal System.Windows.Forms.Label Label1;
    }
}

