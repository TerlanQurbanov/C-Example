using System;
using System.Collections;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
namespace Resource_Ekleme_Okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(openFileDialog1.FileName);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ResXResourceReader rdo =
                    new ResXResourceReader("resources.resx");
                IDictionaryEnumerator nmr = rdo.GetEnumerator();
                while (nmr.MoveNext())
                {
                    listBox1.Items.Add(nmr.Key);
                }
                rdo.Close();
            }
            catch { }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ResXResourceReader rdo = 
                    new ResXResourceReader("resources.resx");
                IDictionaryEnumerator nmr = rdo.GetEnumerator();
                while (nmr.MoveNext())
            {
                if (nmr.Key.ToString() == listBox1.Text.ToString())                    
                pictureBox1.Image = 
                    new Bitmap(nmr.Value.ToString());                    
            }
                rdo.Close();
            }
            catch { }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ResXResourceWriter rdy =
                new ResXResourceWriter("resources.resx");
            Byte i;
            for (i = 0; i <= listBox1.Items.Count - 1; i++)
                rdy.AddResource("Resim" + i, listBox1.Items[i].ToString());
            rdy.Close();
            MessageBox.Show
              ("Tüm dosyalar resources dosyası içerisine kaydedildi!");
        }
    }
}
