namespace Regex_Matches_listBox
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(188, 12);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(146, 173);
            this.ListBox1.TabIndex = 12;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(134, 191);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(75, 23);
            this.btnIslem.TabIndex = 11;
            this.btnIslem.Text = "İşlem Yap";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 169);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Adı:Osman\r\nSoyadı:AKTAŞ\r\nAdı:Elife\r\nSoyadı:AKTAŞ\r\nAdı:Volkan\r\nSoyadı:AKTAŞ\r\nAdı:A" +
    "yşe\r\nSoyadı:AKTAŞ\r\nAdı:Talha Osman\r\nSoyadı:AKTAŞ\r\nAdı:Sümeyye\r\nSoyadı:AKTAŞ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 218);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button btnIslem;
        internal System.Windows.Forms.TextBox textBox1;
    }
}

