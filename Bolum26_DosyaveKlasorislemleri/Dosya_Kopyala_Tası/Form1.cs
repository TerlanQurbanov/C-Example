using System;
using System.IO;
using System.Windows.Forms;
namespace Dosya_Kopyala_Tası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKopyala_Click(object sender, EventArgs e)
        {
            File.Copy(txtKaynak.Text, txtHedef.Text);
        }
        private void btnTası_Click(object sender, EventArgs e)
        {
            File.Move(txtKaynak.Text, txtHedef.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtHedef.Text))
                File.Delete(txtHedef.Text);
        }
    }
}
