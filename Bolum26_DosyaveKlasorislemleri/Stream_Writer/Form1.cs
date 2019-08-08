using System;
using System.IO;
using System.Windows.Forms;
namespace Stream_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("E:\\ornek.txt",
                FileMode.Create, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBox1.Text);
            sw.Close();
            MessageBox.Show("Dosya oluşturuldu ve yazılar eklendi");
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("E:\\ornek.txt");
            //textBox1.Text = sr.ReadToEnd();
            string satır = "";
            do
            {
                satır = sr.ReadLine();
                textBox1.Text = textBox1.Text + satır + Environment.NewLine;
            }
            while (!(satır == null));
        }
    }
}
