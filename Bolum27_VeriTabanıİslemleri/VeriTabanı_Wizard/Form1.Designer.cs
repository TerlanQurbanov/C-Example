namespace VeriTabanı_Wizard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dS = new VeriTabanı_Wizard.DS();
            this.sozcuklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sozcuklerTableAdapter = new VeriTabanı_Wizard.DSTableAdapters.sozcuklerTableAdapter();
            this.ingilizceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turkceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozcuklerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingilizceDataGridViewTextBoxColumn,
            this.turkceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sozcuklerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sozcuklerBindingSource
            // 
            this.sozcuklerBindingSource.DataMember = "sozcukler";
            this.sozcuklerBindingSource.DataSource = this.dS;
            // 
            // sozcuklerTableAdapter
            // 
            this.sozcuklerTableAdapter.ClearBeforeFill = true;
            // 
            // ingilizceDataGridViewTextBoxColumn
            // 
            this.ingilizceDataGridViewTextBoxColumn.DataPropertyName = "ingilizce";
            this.ingilizceDataGridViewTextBoxColumn.HeaderText = "ingilizce";
            this.ingilizceDataGridViewTextBoxColumn.Name = "ingilizceDataGridViewTextBoxColumn";
            // 
            // turkceDataGridViewTextBoxColumn
            // 
            this.turkceDataGridViewTextBoxColumn.DataPropertyName = "turkce";
            this.turkceDataGridViewTextBoxColumn.HeaderText = "turkce";
            this.turkceDataGridViewTextBoxColumn.Name = "turkceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozcuklerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DS dS;
        private System.Windows.Forms.BindingSource sozcuklerBindingSource;
        private DSTableAdapters.sozcuklerTableAdapter sozcuklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingilizceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turkceDataGridViewTextBoxColumn;


    }
}

