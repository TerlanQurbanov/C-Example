namespace CheckedListBox_Secim
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTumunuSec = new System.Windows.Forms.Button();
            this.btnSecimiKaldir = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 15);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(179, 208);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(217, 12);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 212);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnTumunuSec
            // 
            this.btnTumunuSec.Location = new System.Drawing.Point(16, 266);
            this.btnTumunuSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTumunuSec.Name = "btnTumunuSec";
            this.btnTumunuSec.Size = new System.Drawing.Size(109, 28);
            this.btnTumunuSec.TabIndex = 3;
            this.btnTumunuSec.Text = "Tümünü Seç";
            this.btnTumunuSec.UseVisualStyleBackColor = true;
            this.btnTumunuSec.Click += new System.EventHandler(this.btnTumunuSec_Click);
            // 
            // btnSecimiKaldir
            // 
            this.btnSecimiKaldir.Location = new System.Drawing.Point(133, 266);
            this.btnSecimiKaldir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSecimiKaldir.Name = "btnSecimiKaldir";
            this.btnSecimiKaldir.Size = new System.Drawing.Size(100, 28);
            this.btnSecimiKaldir.TabIndex = 4;
            this.btnSecimiKaldir.Text = "Seçimi Kaldır";
            this.btnSecimiKaldir.UseVisualStyleBackColor = true;
            this.btnSecimiKaldir.Click += new System.EventHandler(this.btnSecimiKaldir_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(241, 266);
            this.btnAktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(148, 28);
            this.btnAktar.TabIndex = 5;
            this.btnAktar.Text = "Seçili Olanları Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 306);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnSecimiKaldir);
            this.Controls.Add(this.btnTumunuSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTumunuSec;
        private System.Windows.Forms.Button btnSecimiKaldir;
        private System.Windows.Forms.Button btnAktar;
    }
}

