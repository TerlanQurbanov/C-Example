namespace word_tablo
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
            this.btntabloekle = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntabloekle
            // 
            this.btntabloekle.Location = new System.Drawing.Point(12, 227);
            this.btntabloekle.Name = "btntabloekle";
            this.btntabloekle.Size = new System.Drawing.Size(75, 23);
            this.btntabloekle.TabIndex = 0;
            this.btntabloekle.Text = "Tablo Ekle";
            this.btntabloekle.UseVisualStyleBackColor = true;
            this.btntabloekle.Click += new System.EventHandler(this.btntabloekle_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(197, 227);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 23);
            this.btnkapat.TabIndex = 1;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btntabloekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntabloekle;
        private System.Windows.Forms.Button btnkapat;
    }
}

