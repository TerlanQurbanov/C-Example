using System;
using System.Windows.Forms;

namespace Buton_Tıklanma_Sayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 0;
            Form2.i = Form2.i + 1;
            MessageBox.Show(Form2.i + " defa tıklandı");
        }
    }
}
