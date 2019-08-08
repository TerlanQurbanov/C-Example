namespace IsolatedStorageFile_DosyayaYazma
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
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKlasor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(66, 43);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(148, 20);
            this.txtDosya.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dosya Adı";
            // 
            // txtKlasor
            // 
            this.txtKlasor.Location = new System.Drawing.Point(66, 12);
            this.txtKlasor.Name = "txtKlasor";
            this.txtKlasor.Size = new System.Drawing.Size(148, 20);
            this.txtKlasor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Klasör Adı";
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(66, 149);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(75, 23);
            this.btnIslemYap.TabIndex = 8;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(66, 78);
            this.txticerik.Multiline = true;
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(148, 60);
            this.txticerik.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dosya Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 177);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKlasor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIslemYap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKlasor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.TextBox txticerik;
        private System.Windows.Forms.Label label3;
    }
}

