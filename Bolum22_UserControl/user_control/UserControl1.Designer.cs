namespace user_control
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metin_kutusu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metin_kutusu
            // 
            this.metin_kutusu.Location = new System.Drawing.Point(3, 3);
            this.metin_kutusu.Name = "metin_kutusu";
            this.metin_kutusu.Size = new System.Drawing.Size(184, 20);
            this.metin_kutusu.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.metin_kutusu);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(195, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox metin_kutusu;
    }
}
