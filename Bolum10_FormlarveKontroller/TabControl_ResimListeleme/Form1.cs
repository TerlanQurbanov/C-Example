using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace TabControl_ResimListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] klasorler = Directory.GetDirectories(textBox1.Text);
            if (klasorler.Length != 0)
            {
                foreach (string aktifklasor in klasorler)
                {
                    i++;
                    TabPage tp = new TabPage("tp" + i);
                    tabControl1.TabPages.Add(tp);

                    ListView lstv = new ListView();
                    lstv.Size = new System.Drawing.Size(420, 330);
                    lstv.View = View.LargeIcon;

                    ImageList imgl = new ImageList();
                    imgl.ImageSize = new Size(128, 128);

                    tabControl1.TabPages[i].Text = Path.GetFileName(aktifklasor);

                    string[] dosyalar = Directory.GetFiles(aktifklasor, "*.jpg", SearchOption.AllDirectories);
                    imgl.Images.Clear();
                    foreach (string aktifdosya in dosyalar)
                    {
                        imgl.Images.Add(Image.FromFile(aktifdosya));
                    }
                    for (int j = 0; j < imgl.Images.Count; j++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = j;
                        lstv.Items.Add(item);
                    }
                    lstv.LargeImageList = imgl;
                    tabControl1.TabPages[i].Controls.Add(lstv);
                }
            }
            tabControl1.TabPages.RemoveAt(0);
        }
    }
}
