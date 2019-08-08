using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser_AracCubukları_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte i;       
        private void tbSayfalar_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            webBrowser1.Navigate(e.ClickedItem.Text);
        }
        private void tsSayfalar_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            webBrowser1.Navigate(e.ClickedItem.Text);
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtadres.Text = e.Url.ToString();
            timer1.Stop();
            toolStripStatusLabel1.Text = txtadres.Text + " sayfası yüklendi";
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Visible = false;
            //tsSayfalar.Visible = true;
        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            toolStripLabel1.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Text = txtadres.Text +
                                    " adresi yüklenmeye başladı";
            toolStripProgressBar1.Value = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = txtadres.Text + " Sayfa Yükleniyor ";
            if (toolStripProgressBar1.Value == 100)
                toolStripProgressBar1.Value = 0;
            else
                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 10;  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = false;
        }

        private void GeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); 
        }
        private void İleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void AnaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        private void AramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }
        private void DurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            if (!(txtadres.Text.StartsWith("http://")))
                txtadres.Text = txtadres.Text.Insert(0, "http://");
            webBrowser1.Navigate(txtadres.Text);
            Cursor.Current = Cursors.Default;

            ToolStripMenuItem yenimenu = new ToolStripMenuItem(String.Format(txtadres.Text, i));
            tbSayfalar.DropDownItems.Add(yenimenu);
            tsSayfalar.DropDownItems.Add(yenimenu);
        }
    }
}
