namespace IsolatedStorageFile_DosyaOlusturma
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
            this.txtKlasor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKlasor
            // 
            this.txtKlasor.Location = new System.Drawing.Point(69, 12);
            this.txtKlasor.Name = "txtKlasor";
            this.txtKlasor.Size = new System.Drawing.Size(148, 20);
            this.txtKlasor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Klasör Adı";
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Location = new System.Drawing.Point(79, 74);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(75, 23);
            this.btnIslemYap.TabIndex = 3;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = true;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(69, 43);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(148, 20);
            this.txtDosya.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dosya Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 109);
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

        private System.Windows.Forms.TextBox txtKlasor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Label label2;
    }
}

