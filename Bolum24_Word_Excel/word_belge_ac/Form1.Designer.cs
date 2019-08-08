namespace word_belge_ac
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
            this.btnBelgeAc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnBelgeAc
            // 
            this.btnBelgeAc.Location = new System.Drawing.Point(116, 218);
            this.btnBelgeAc.Name = "btnBelgeAc";
            this.btnBelgeAc.Size = new System.Drawing.Size(75, 23);
            this.btnBelgeAc.TabIndex = 0;
            this.btnBelgeAc.Text = "Belge Aç";
            this.btnBelgeAc.UseVisualStyleBackColor = true;
            this.btnBelgeAc.Click += new System.EventHandler(this.btnBelgeAc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBelgeAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBelgeAc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

