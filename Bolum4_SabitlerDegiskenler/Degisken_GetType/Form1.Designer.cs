namespace Degisken_GetType
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
            this.btnDegiskenTipi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegiskenTipi
            // 
            this.btnDegiskenTipi.Location = new System.Drawing.Point(105, 209);
            this.btnDegiskenTipi.Name = "btnDegiskenTipi";
            this.btnDegiskenTipi.Size = new System.Drawing.Size(101, 23);
            this.btnDegiskenTipi.TabIndex = 0;
            this.btnDegiskenTipi.Text = "Değişken Tipi";
            this.btnDegiskenTipi.UseVisualStyleBackColor = true;
            this.btnDegiskenTipi.Click += new System.EventHandler(this.btnDegiskenTipi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDegiskenTipi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDegiskenTipi;
    }
}

