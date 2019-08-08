using System;
using System.Text;
using System.Windows.Forms;
namespace StringBuilder_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            sb.AppendLine("VB.Net");
            sb.AppendLine("C#.Net");
            sb.AppendLine("Visual C++.Net");
            sb.AppendLine("F#");
            sb.AppendLine("Iron Python");
            textBox1.Text = sb.ToString();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sb.Insert(0, "Programlama Dilleri" + "\r\n");
            sb.Insert(21, "-", 30);
            sb.Insert(51, "\r\n");
            textBox1.Text = sb.ToString();
        }
    }
}
