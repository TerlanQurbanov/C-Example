using System;
using System.Text;
using System.Windows.Forms;
namespace StringBuilder_Remove
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
        private void btnSil_Click(object sender, EventArgs e)
        {
            sb.Remove(0, 7);
            textBox1.Text = sb.ToString();
        }
    }
}
