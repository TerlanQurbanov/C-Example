namespace sozluk_oledbdataadapter
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
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.txtaranan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstsonuc = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(250, 19);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(202, 238);
            this.txtsonuc.TabIndex = 1;
            // 
            // txtaranan
            // 
            this.txtaranan.Location = new System.Drawing.Point(6, 19);
            this.txtaranan.Name = "txtaranan";
            this.txtaranan.Size = new System.Drawing.Size(446, 20);
            this.txtaranan.TabIndex = 1;
            this.txtaranan.TextChanged += new System.EventHandler(this.txtaranan_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaranan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 53);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aradığınız Kelime";
            // 
            // btnAyar
            // 
            this.btnAyar.Location = new System.Drawing.Point(15, 16);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(119, 47);
            this.btnAyar.TabIndex = 2;
            this.btnAyar.Text = "Ayarlar";
            this.btnAyar.UseVisualStyleBackColor = true;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(333, 16);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(119, 47);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAyar);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Location = new System.Drawing.Point(12, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 75);
            this.panel1.TabIndex = 15;
            // 
            // lstsonuc
            // 
            this.lstsonuc.FormattingEnabled = true;
            this.lstsonuc.Location = new System.Drawing.Point(15, 19);
            this.lstsonuc.Name = "lstsonuc";
            this.lstsonuc.Size = new System.Drawing.Size(208, 238);
            this.lstsonuc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsonuc);
            this.groupBox2.Controls.Add(this.lstsonuc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 268);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.TextBox txtaranan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAyar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstsonuc;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

