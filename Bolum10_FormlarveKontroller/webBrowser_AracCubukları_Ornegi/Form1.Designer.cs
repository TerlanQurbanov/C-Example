namespace webBrowser_AracCubukları_Ornegi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GezintiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.İleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtadres = new System.Windows.Forms.ToolStripTextBox();
            this.btngit = new System.Windows.Forms.ToolStripButton();
            this.tbSayfalar = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbileri = new System.Windows.Forms.ToolStripButton();
            this.tbgit = new System.Windows.Forms.ToolStripButton();
            this.tbgeri = new System.Windows.Forms.ToolStripButton();
            this.tbAnaSayfa = new System.Windows.Forms.ToolStripButton();
            this.tbArama = new System.Windows.Forms.ToolStripButton();
            this.tbDur = new System.Windows.Forms.ToolStripButton();
            this.tbCikis = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GeriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.İleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tsSayfalar = new System.Windows.Forms.ToolStripDropDownButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GezintiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 71);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "MenuStrip1";
            // 
            // GezintiToolStripMenuItem
            // 
            this.GezintiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitToolStripMenuItem,
            this.GeriToolStripMenuItem,
            this.İleriToolStripMenuItem,
            this.AnaSayfaToolStripMenuItem,
            this.AramaToolStripMenuItem,
            this.DurToolStripMenuItem,
            this.ÇıkışToolStripMenuItem});
            this.GezintiToolStripMenuItem.Name = "GezintiToolStripMenuItem";
            this.GezintiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.GezintiToolStripMenuItem.Text = "Gezinti";
            // 
            // GitToolStripMenuItem
            // 
            this.GitToolStripMenuItem.Name = "GitToolStripMenuItem";
            this.GitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.GitToolStripMenuItem.Text = "Git";
            this.GitToolStripMenuItem.Click += new System.EventHandler(this.GitToolStripMenuItem_Click);
            // 
            // GeriToolStripMenuItem
            // 
            this.GeriToolStripMenuItem.Name = "GeriToolStripMenuItem";
            this.GeriToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.GeriToolStripMenuItem.Text = "Geri";
            this.GeriToolStripMenuItem.Click += new System.EventHandler(this.GeriToolStripMenuItem_Click);
            // 
            // İleriToolStripMenuItem
            // 
            this.İleriToolStripMenuItem.Name = "İleriToolStripMenuItem";
            this.İleriToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.İleriToolStripMenuItem.Text = "İleri";
            this.İleriToolStripMenuItem.Click += new System.EventHandler(this.İleriToolStripMenuItem_Click);
            // 
            // AnaSayfaToolStripMenuItem
            // 
            this.AnaSayfaToolStripMenuItem.Name = "AnaSayfaToolStripMenuItem";
            this.AnaSayfaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AnaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.AnaSayfaToolStripMenuItem.Click += new System.EventHandler(this.AnaSayfaToolStripMenuItem_Click);
            // 
            // AramaToolStripMenuItem
            // 
            this.AramaToolStripMenuItem.Name = "AramaToolStripMenuItem";
            this.AramaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AramaToolStripMenuItem.Text = "Arama";
            this.AramaToolStripMenuItem.Click += new System.EventHandler(this.AramaToolStripMenuItem_Click);
            // 
            // DurToolStripMenuItem
            // 
            this.DurToolStripMenuItem.Name = "DurToolStripMenuItem";
            this.DurToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.DurToolStripMenuItem.Text = "Dur";
            this.DurToolStripMenuItem.Click += new System.EventHandler(this.DurToolStripMenuItem_Click);
            // 
            // ÇıkışToolStripMenuItem
            // 
            this.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem";
            this.ÇıkışToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ÇıkışToolStripMenuItem.Text = "Çıkış";
            this.ÇıkışToolStripMenuItem.Click += new System.EventHandler(this.ÇıkışToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtadres,
            this.btngit,
            this.tbSayfalar,
            this.ToolStripSeparator1,
            this.tbileri,
            this.tbgit,
            this.tbgeri,
            this.tbAnaSayfa,
            this.tbArama,
            this.tbDur,
            this.tbCikis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 71);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "ToolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 68);
            this.toolStripLabel1.Text = "Adres:";
            // 
            // txtadres
            // 
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(200, 71);
            // 
            // btngit
            // 
            this.btngit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btngit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btngit.Image = ((System.Drawing.Image)(resources.GetObject("btngit.Image")));
            this.btngit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btngit.Name = "btngit";
            this.btngit.Size = new System.Drawing.Size(26, 68);
            this.btngit.Text = "Git";
            this.btngit.Click += new System.EventHandler(this.GitToolStripMenuItem_Click);
            // 
            // tbSayfalar
            // 
            this.tbSayfalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSayfalar.Image = global::webBrowser_AracCubukları_Ornegi.Resource1.favorites;
            this.tbSayfalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSayfalar.Name = "tbSayfalar";
            this.tbSayfalar.Size = new System.Drawing.Size(77, 68);
            this.tbSayfalar.Text = "Sayfalar";
            this.tbSayfalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbSayfalar.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbSayfalar_DropDownItemClicked);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // tbileri
            // 
            this.tbileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbileri.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._006;
            this.tbileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbileri.Name = "tbileri";
            this.tbileri.Size = new System.Drawing.Size(68, 68);
            this.tbileri.Text = "İleri";
            this.tbileri.Click += new System.EventHandler(this.İleriToolStripMenuItem_Click);
            // 
            // tbgit
            // 
            this.tbgit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbgit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbgit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbgit.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._043;
            this.tbgit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbgit.Name = "tbgit";
            this.tbgit.Size = new System.Drawing.Size(68, 68);
            this.tbgit.Text = "Git";
            this.tbgit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tbgit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbgit.Click += new System.EventHandler(this.GitToolStripMenuItem_Click);
            // 
            // tbgeri
            // 
            this.tbgeri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbgeri.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._008;
            this.tbgeri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbgeri.Name = "tbgeri";
            this.tbgeri.Size = new System.Drawing.Size(68, 68);
            this.tbgeri.Text = "Geri";
            this.tbgeri.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tbgeri.Click += new System.EventHandler(this.GeriToolStripMenuItem_Click);
            // 
            // tbAnaSayfa
            // 
            this.tbAnaSayfa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAnaSayfa.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._073;
            this.tbAnaSayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAnaSayfa.Name = "tbAnaSayfa";
            this.tbAnaSayfa.Size = new System.Drawing.Size(68, 68);
            this.tbAnaSayfa.Text = "Ana Sayfa";
            this.tbAnaSayfa.Click += new System.EventHandler(this.AnaSayfaToolStripMenuItem_Click);
            // 
            // tbArama
            // 
            this.tbArama.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbArama.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._036;
            this.tbArama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbArama.Name = "tbArama";
            this.tbArama.Size = new System.Drawing.Size(68, 68);
            this.tbArama.Text = "Arama";
            this.tbArama.Click += new System.EventHandler(this.AramaToolStripMenuItem_Click);
            // 
            // tbDur
            // 
            this.tbDur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDur.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._031;
            this.tbDur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDur.Name = "tbDur";
            this.tbDur.Size = new System.Drawing.Size(68, 68);
            this.tbDur.Text = "Dur";
            this.tbDur.Click += new System.EventHandler(this.DurToolStripMenuItem_Click);
            // 
            // tbCikis
            // 
            this.tbCikis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCikis.Image = global::webBrowser_AracCubukları_Ornegi.Resource1._039;
            this.tbCikis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCikis.Name = "tbCikis";
            this.tbCikis.Size = new System.Drawing.Size(68, 68);
            this.tbCikis.Text = "Çıkış";
            this.tbCikis.Click += new System.EventHandler(this.ÇıkışToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeriToolStripMenuItem1,
            this.İleriToolStripMenuItem1,
            this.DurToolStripMenuItem1});
            this.contextMenuStrip1.Name = "ContextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 70);
            // 
            // GeriToolStripMenuItem1
            // 
            this.GeriToolStripMenuItem1.Name = "GeriToolStripMenuItem1";
            this.GeriToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.GeriToolStripMenuItem1.Text = "Geri";
            // 
            // İleriToolStripMenuItem1
            // 
            this.İleriToolStripMenuItem1.Name = "İleriToolStripMenuItem1";
            this.İleriToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.İleriToolStripMenuItem1.Text = "İleri";
            // 
            // DurToolStripMenuItem1
            // 
            this.DurToolStripMenuItem1.Name = "DurToolStripMenuItem1";
            this.DurToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.DurToolStripMenuItem1.Text = "Dur";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.tsSayfalar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "StatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tsSayfalar
            // 
            this.tsSayfalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSayfalar.Image = ((System.Drawing.Image)(resources.GetObject("tsSayfalar.Image")));
            this.tsSayfalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSayfalar.Name = "tsSayfalar";
            this.tsSayfalar.Size = new System.Drawing.Size(61, 20);
            this.tsSayfalar.Text = "Sayfalar";
            this.tsSayfalar.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsSayfalar_DropDownItemClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Location = new System.Drawing.Point(14, 89);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(862, 442);
            this.webBrowser1.TabIndex = 12;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 608);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem GezintiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GeriToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem İleriToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AnaSayfaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AramaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DurToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ÇıkışToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox txtadres;
        internal System.Windows.Forms.ToolStripButton btngit;
        internal System.Windows.Forms.ToolStripDropDownButton tbSayfalar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tbileri;
        internal System.Windows.Forms.ToolStripButton tbgit;
        internal System.Windows.Forms.ToolStripButton tbgeri;
        internal System.Windows.Forms.ToolStripButton tbAnaSayfa;
        internal System.Windows.Forms.ToolStripButton tbArama;
        internal System.Windows.Forms.ToolStripButton tbDur;
        internal System.Windows.Forms.ToolStripButton tbCikis;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem GeriToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem İleriToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem DurToolStripMenuItem1;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        internal System.Windows.Forms.ToolStripDropDownButton tsSayfalar;
        internal System.Windows.Forms.WebBrowser webBrowser1;

    }
}

