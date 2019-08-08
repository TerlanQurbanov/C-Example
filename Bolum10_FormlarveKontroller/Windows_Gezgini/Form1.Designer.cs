namespace Windows_Gezgini
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNitelik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDosyaTuru = new System.Windows.Forms.ComboBox();
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dosya Niteliği :";
            // 
            // cmbNitelik
            // 
            this.cmbNitelik.FormattingEnabled = true;
            this.cmbNitelik.Items.AddRange(new object[] {
            "Arşiv Dosyaları",
            "Gizli Dosyalar",
            "Sistem Dosyaları",
            "Yalnız Okunabilir Dosyalar"});
            this.cmbNitelik.Location = new System.Drawing.Point(471, 7);
            this.cmbNitelik.Name = "cmbNitelik";
            this.cmbNitelik.Size = new System.Drawing.Size(93, 21);
            this.cmbNitelik.TabIndex = 13;
            this.cmbNitelik.SelectedIndexChanged += new System.EventHandler(this.cmbNitelik_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dosya Türü :";
            // 
            // cmbDosyaTuru
            // 
            this.cmbDosyaTuru.FormattingEnabled = true;
            this.cmbDosyaTuru.Items.AddRange(new object[] {
            "*.*",
            "*.txt;*.doc",
            "*.jpg;*.jpeg;*.gif;*.bmp;*.png",
            "*.exe"});
            this.cmbDosyaTuru.Location = new System.Drawing.Point(285, 7);
            this.cmbDosyaTuru.Name = "cmbDosyaTuru";
            this.cmbDosyaTuru.Size = new System.Drawing.Size(93, 21);
            this.cmbDosyaTuru.TabIndex = 11;
            this.cmbDosyaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbDosyaTuru_SelectedIndexChanged);
            // 
            // driveListBox1
            // 
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(12, 7);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(196, 21);
            this.driveListBox1.TabIndex = 15;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // dirListBox1
            // 
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(12, 34);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(196, 278);
            this.dirListBox1.TabIndex = 16;
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            // 
            // fileListBox1
            // 
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(214, 34);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.*";
            this.fileListBox1.Size = new System.Drawing.Size(350, 277);
            this.fileListBox1.TabIndex = 17;
            this.fileListBox1.DoubleClick += new System.EventHandler(this.fileListBox1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 324);
            this.Controls.Add(this.fileListBox1);
            this.Controls.Add(this.dirListBox1);
            this.Controls.Add(this.driveListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNitelik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDosyaTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbNitelik;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbDosyaTuru;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
    }
}

