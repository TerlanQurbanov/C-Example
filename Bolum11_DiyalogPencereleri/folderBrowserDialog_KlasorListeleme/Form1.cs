using System;
using System.IO;
using System.Windows.Forms;
namespace folderBrowserDialog_KlasorListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            DialogResult basilan_tus;
            basilan_tus = folderBrowserDialog1.ShowDialog();
            if (basilan_tus == DialogResult.OK)
            {
                DirectoryInfo dosya = new
                    DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] belgeler = dosya.GetFiles("*.doc");
                foreach (FileInfo b in belgeler)                
                    listBox1.Items.Add(b.Name);                
            }
        }
    }
}
