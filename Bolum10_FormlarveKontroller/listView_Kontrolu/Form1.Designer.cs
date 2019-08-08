namespace listView_Kontrolu
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Dosya", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Düzen", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kopyala",
            "Aktif"}, 5);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kaydetme",
            "Aktif"}, 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Çıkış",
            "Aktif"}, 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Arama",
            "Pasif"}, 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Araçlar",
            "Pasif"}, 8);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Small_imglst = new System.Windows.Forms.ImageList(this.components);
            this.Large_imglst = new System.Windows.Forms.ImageList(this.components);
            this.State_imglst = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup1.Header = "Dosya";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Düzen";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.LargeImageList = this.Large_imglst;
            this.listView1.Location = new System.Drawing.Point(12, 23);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(468, 221);
            this.listView1.SmallImageList = this.Small_imglst;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // Small_imglst
            // 
            this.Small_imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Small_imglst.ImageStream")));
            this.Small_imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.Small_imglst.Images.SetKeyName(0, "arama.png");
            this.Small_imglst.Images.SetKeyName(1, "exit.png");
            this.Small_imglst.Images.SetKeyName(2, "geri.png");
            this.Small_imglst.Images.SetKeyName(3, "help.png");
            this.Small_imglst.Images.SetKeyName(4, "ileri.png");
            this.Small_imglst.Images.SetKeyName(5, "kopyala.png");
            this.Small_imglst.Images.SetKeyName(6, "resim.png");
            this.Small_imglst.Images.SetKeyName(7, "takvim.png");
            this.Small_imglst.Images.SetKeyName(8, "tools.png");
            // 
            // Large_imglst
            // 
            this.Large_imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Large_imglst.ImageStream")));
            this.Large_imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.Large_imglst.Images.SetKeyName(0, "arama.png");
            this.Large_imglst.Images.SetKeyName(1, "exit.png");
            this.Large_imglst.Images.SetKeyName(2, "geri.png");
            this.Large_imglst.Images.SetKeyName(3, "help.png");
            this.Large_imglst.Images.SetKeyName(4, "ileri.png");
            this.Large_imglst.Images.SetKeyName(5, "kopyala.png");
            this.Large_imglst.Images.SetKeyName(6, "resim.png");
            this.Large_imglst.Images.SetKeyName(7, "takvim.png");
            this.Large_imglst.Images.SetKeyName(8, "tools.png");
            // 
            // State_imglst
            // 
            this.State_imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("State_imglst.ImageStream")));
            this.State_imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.State_imglst.Images.SetKeyName(0, "arama.png");
            this.State_imglst.Images.SetKeyName(1, "exit.png");
            this.State_imglst.Images.SetKeyName(2, "geri.png");
            this.State_imglst.Images.SetKeyName(3, "help.png");
            this.State_imglst.Images.SetKeyName(4, "ileri.png");
            this.State_imglst.Images.SetKeyName(5, "kopyala.png");
            this.State_imglst.Images.SetKeyName(6, "resim.png");
            this.State_imglst.Images.SetKeyName(7, "takvim.png");
            this.State_imglst.Images.SetKeyName(8, "tools.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Menü";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 262);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList Large_imglst;
        private System.Windows.Forms.ImageList Small_imglst;
        private System.Windows.Forms.ImageList State_imglst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

