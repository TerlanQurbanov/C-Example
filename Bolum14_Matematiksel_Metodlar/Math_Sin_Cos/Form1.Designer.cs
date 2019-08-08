namespace Math_Sin_Cos
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
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdDerece = new System.Windows.Forms.RadioButton();
            this.rdRadyan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(11, 69);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(75, 23);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "Sinüs";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(163, 69);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(75, 23);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "Cosinüs";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 2;
            // 
            // rdDerece
            // 
            this.rdDerece.AutoSize = true;
            this.rdDerece.Checked = true;
            this.rdDerece.Location = new System.Drawing.Point(11, 44);
            this.rdDerece.Name = "rdDerece";
            this.rdDerece.Size = new System.Drawing.Size(60, 17);
            this.rdDerece.TabIndex = 3;
            this.rdDerece.TabStop = true;
            this.rdDerece.Text = "Derece";
            this.rdDerece.UseVisualStyleBackColor = true;
            // 
            // rdRadyan
            // 
            this.rdRadyan.AutoSize = true;
            this.rdRadyan.Location = new System.Drawing.Point(163, 44);
            this.rdRadyan.Name = "rdRadyan";
            this.rdRadyan.Size = new System.Drawing.Size(62, 17);
            this.rdRadyan.TabIndex = 4;
            this.rdRadyan.TabStop = true;
            this.rdRadyan.Text = "Radyan";
            this.rdRadyan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 101);
            this.Controls.Add(this.rdRadyan);
            this.Controls.Add(this.rdDerece);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdDerece;
        private System.Windows.Forms.RadioButton rdRadyan;
    }
}

