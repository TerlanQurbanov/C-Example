namespace DateTime_Equals
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(15, 79);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(16, 13);
            this.lblSonuc.TabIndex = 17;
            this.lblSonuc.Text = "...";
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(57, 99);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(100, 23);
            this.btnKarsilastir.TabIndex = 16;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(99, 48);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.Size = new System.Drawing.Size(100, 20);
            this.txtTarih2.TabIndex = 15;
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(99, 12);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.Size = new System.Drawing.Size(100, 20);
            this.txtTarih1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "2. Tarih Değeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "1. Tarih Değeri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 129);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.txtTarih2);
            this.Controls.Add(this.txtTarih1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.TextBox txtTarih2;
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

