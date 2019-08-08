namespace CheckBox_Yazıtipi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkKalin = new System.Windows.Forms.CheckBox();
            this.chkEgik = new System.Windows.Forms.CheckBox();
            this.chkAltiCizili = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Visual Studio";
            // 
            // chkKalin
            // 
            this.chkKalin.AutoSize = true;
            this.chkKalin.Location = new System.Drawing.Point(12, 58);
            this.chkKalin.Name = "chkKalin";
            this.chkKalin.Size = new System.Drawing.Size(49, 17);
            this.chkKalin.TabIndex = 1;
            this.chkKalin.Text = "Kalın";
            this.chkKalin.UseVisualStyleBackColor = true;
            this.chkKalin.CheckedChanged += new System.EventHandler(this.chkKalin_CheckedChanged);
            // 
            // chkEgik
            // 
            this.chkEgik.AutoSize = true;
            this.chkEgik.Location = new System.Drawing.Point(98, 57);
            this.chkEgik.Name = "chkEgik";
            this.chkEgik.Size = new System.Drawing.Size(47, 17);
            this.chkEgik.TabIndex = 2;
            this.chkEgik.Text = "Eğik";
            this.chkEgik.UseVisualStyleBackColor = true;
            this.chkEgik.CheckedChanged += new System.EventHandler(this.chkEgik_CheckedChanged);
            // 
            // chkAltiCizili
            // 
            this.chkAltiCizili.AutoSize = true;
            this.chkAltiCizili.Location = new System.Drawing.Point(173, 57);
            this.chkAltiCizili.Name = "chkAltiCizili";
            this.chkAltiCizili.Size = new System.Drawing.Size(63, 17);
            this.chkAltiCizili.TabIndex = 3;
            this.chkAltiCizili.Text = "Altı Çizili";
            this.chkAltiCizili.UseVisualStyleBackColor = true;
            this.chkAltiCizili.CheckedChanged += new System.EventHandler(this.chkAltiCizili_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 91);
            this.Controls.Add(this.chkAltiCizili);
            this.Controls.Add(this.chkEgik);
            this.Controls.Add(this.chkKalin);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkKalin;
        private System.Windows.Forms.CheckBox chkEgik;
        private System.Windows.Forms.CheckBox chkAltiCizili;
    }
}

