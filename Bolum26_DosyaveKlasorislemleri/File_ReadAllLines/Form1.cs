using System;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms;
namespace File_ReadAllLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string eklenecek;
            eklenecek = Interaction.InputBox("Eklenecek değeri girin");
            listBox1.Items.Add(eklenecek);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                String[] degerler = new String[] { };
                degerler = (File.ReadAllLines("D:\\ornek.txt"));
                for (int i = 0; i <= degerler.Length; i++)
                    listBox1.Items.Add(degerler.GetValue(i));
            }
            catch
            { }
        }
        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\ornek.txt",
                FileMode.Create, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                sw.WriteLine(listBox1.Items[i]);
            sw.Close();

        }
    }
}
