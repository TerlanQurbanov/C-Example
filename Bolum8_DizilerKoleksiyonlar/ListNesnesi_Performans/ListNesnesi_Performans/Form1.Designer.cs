namespace ListNesnesi_Performans
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnlistTekrarsiz = new System.Windows.Forms.Button();
            this.btnforTekrarsız = new System.Windows.Forms.Button();
            this.lblForSonuc = new System.Windows.Forms.Label();
            this.lbListSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(13, 217);
            this.btnAktar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(154, 28);
            this.btnAktar.TabIndex = 0;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 196);
            this.listBox1.TabIndex = 1;
            // 
            // btnlistTekrarsiz
            // 
            this.btnlistTekrarsiz.Location = new System.Drawing.Point(13, 289);
            this.btnlistTekrarsiz.Margin = new System.Windows.Forms.Padding(4);
            this.btnlistTekrarsiz.Name = "btnlistTekrarsiz";
            this.btnlistTekrarsiz.Size = new System.Drawing.Size(154, 28);
            this.btnlistTekrarsiz.TabIndex = 2;
            this.btnlistTekrarsiz.Text = "list İle Tekrarsız Yaz";
            this.btnlistTekrarsiz.UseVisualStyleBackColor = true;
            this.btnlistTekrarsiz.Click += new System.EventHandler(this.btnlistTekrarsiz_Click);
            // 
            // btnforTekrarsız
            // 
            this.btnforTekrarsız.Location = new System.Drawing.Point(13, 253);
            this.btnforTekrarsız.Margin = new System.Windows.Forms.Padding(4);
            this.btnforTekrarsız.Name = "btnforTekrarsız";
            this.btnforTekrarsız.Size = new System.Drawing.Size(154, 28);
            this.btnforTekrarsız.TabIndex = 3;
            this.btnforTekrarsız.Text = "for İle Tekrarsız Yaz";
            this.btnforTekrarsız.UseVisualStyleBackColor = true;
            this.btnforTekrarsız.Click += new System.EventHandler(this.btnforTekrarsız_Click);
            // 
            // lblForSonuc
            // 
            this.lblForSonuc.AutoSize = true;
            this.lblForSonuc.Location = new System.Drawing.Point(174, 259);
            this.lblForSonuc.Name = "lblForSonuc";
            this.lblForSonuc.Size = new System.Drawing.Size(20, 17);
            this.lblForSonuc.TabIndex = 4;
            this.lblForSonuc.Text = "...";
            // 
            // lbListSonuc
            // 
            this.lbListSonuc.AutoSize = true;
            this.lbListSonuc.Location = new System.Drawing.Point(174, 295);
            this.lbListSonuc.Name = "lbListSonuc";
            this.lbListSonuc.Size = new System.Drawing.Size(20, 17);
            this.lbListSonuc.TabIndex = 5;
            this.lbListSonuc.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 325);
            this.Controls.Add(this.lbListSonuc);
            this.Controls.Add(this.lblForSonuc);
            this.Controls.Add(this.btnforTekrarsız);
            this.Controls.Add(this.btnlistTekrarsiz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAktar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnlistTekrarsiz;
        private System.Windows.Forms.Button btnforTekrarsız;
        private System.Windows.Forms.Label lblForSonuc;
        private System.Windows.Forms.Label lbListSonuc;
    }
}

