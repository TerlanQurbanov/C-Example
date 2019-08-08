using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
namespace textBox_TextChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CultureInfo CI = Thread.CurrentThread.CurrentCulture;
            TextInfo TI = CI.TextInfo;
            textBox1.Text = TI.ToTitleCase(textBox1.Text);
            textBox1.Select(textBox1.Text.Length, 1);            
        }
    }
}
