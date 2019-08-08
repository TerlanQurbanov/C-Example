using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openFileDialog_CokluDosyaSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
           byte i;
           openFileDialog1.Multiselect = true;
           openFileDialog1.FileName = "dosya seç";
           openFileDialog1.Filter = "jpeg dosyaları (*.jpeg) |*.jpg|bmp dosyaları (*.bmp)|*.bmp|gif dosyaları(*.gif)|*.gif";
           openFileDialog1.Title = "Lütfen Bir Resim Dosyası Seçin";
           openFileDialog1.InitialDirectory = "E:\\arka_plan";
           openFileDialog1.ShowDialog();
           for (i=0;i<openFileDialog1.FileNames.Length-1;i++)
           {
            textBox1.Text = textBox1.Text + 
                openFileDialog1.FileNames[i].ToString() + 
                Environment.NewLine;
           }
        }
    }
}
