﻿namespace Strings_IndexOfAny
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
            this.btnislemyap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnislemyap
            // 
            this.btnislemyap.Location = new System.Drawing.Point(74, 47);
            this.btnislemyap.Name = "btnislemyap";
            this.btnislemyap.Size = new System.Drawing.Size(75, 23);
            this.btnislemyap.TabIndex = 0;
            this.btnislemyap.Text = "İşlem Yap";
            this.btnislemyap.UseVisualStyleBackColor = true;
            this.btnislemyap.Click += new System.EventHandler(this.btnislemyap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 82);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnislemyap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnislemyap;
        private System.Windows.Forms.TextBox textBox1;
    }
}

