using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Now_CustomDateTimeFormat.csproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            string sonuc;

            sonuc = string.Format("{0:hh:mm:ss}", DateTime.Now);
            textBox1.AppendText(sonuc + "\n");

            sonuc = string.Format("{0:HH:mm:ss}", DateTime.Now);
            textBox1.AppendText(sonuc + "\n");

            sonuc = string.Format("{0:dd MM yyyy}", DateTime.Now);
            textBox1.AppendText(sonuc + "\n");

            sonuc = string.Format("{0:dd MMMM yyyy}", DateTime.Now);
            textBox1.AppendText(sonuc + "\n");

            sonuc = string.Format("{0:HH:mm:ss dd MMMM yyyy}", DateTime.Now);
            textBox1.AppendText(sonuc + "\n");
        }
    }
}
