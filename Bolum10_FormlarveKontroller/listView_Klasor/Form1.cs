using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace listView_Klasor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageList imglist = new ImageList();            
            imglist.Images.Add(Bitmap.FromFile("./resimler/Dosya.ico"));
            imglist.Images.Add(Bitmap.FromFile("./resimler/Klasor.ico"));
            listView1.SmallImageList = imglist;

            listView1.Columns.Add("İsim");
            listView1.Columns.Add("Boyut");
            listView1.Columns.Add("Tür");

            ListViewItem item;
            String[] klasorler = Directory.GetDirectories(textBox1.Text);
            int boyut = klasorler.Length;
            if (boyut != 0)
            {
                foreach (string aktifklasor in klasorler)
                {
                    item = new ListViewItem(Path.GetFileName(aktifklasor), 1);
                    item.SubItems.Add("");
                    item.SubItems.Add("Klasör");                    
                    listView1.Items.Add(item);
                }

                String[] dosyalar = Directory.GetFiles(textBox1.Text);
                boyut = dosyalar.Length;
                foreach (string aktifdosya in dosyalar)
                {
                    item = new ListViewItem(Path.GetFileName(aktifdosya), 0);
                    FileInfo dosya_bilgisi = new FileInfo(aktifdosya);
                    item.SubItems.Add(Convert.ToString(dosya_bilgisi.Length));
                    item.SubItems.Add("Dosya");                    
                    listView1.Items.Add(item);
                }
            }
            listView1.View = View.Details;
        }
    }
}
