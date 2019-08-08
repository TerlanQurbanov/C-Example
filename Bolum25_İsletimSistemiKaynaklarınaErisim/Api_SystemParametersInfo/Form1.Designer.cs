namespace Api_SystemParametersInfo
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
            this.btnMasaustunuDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasaustunuDegistir
            // 
            this.btnMasaustunuDegistir.Location = new System.Drawing.Point(105, 217);
            this.btnMasaustunuDegistir.Name = "btnMasaustunuDegistir";
            this.btnMasaustunuDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnMasaustunuDegistir.TabIndex = 0;
            this.btnMasaustunuDegistir.Text = "Değiştir";
            this.btnMasaustunuDegistir.UseVisualStyleBackColor = true;
            this.btnMasaustunuDegistir.Click += new System.EventHandler(this.btnMasaustunuDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMasaustunuDegistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasaustunuDegistir;
    }
}

