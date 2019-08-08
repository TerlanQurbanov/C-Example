using System;
using System.Windows.Forms;

namespace Strings_ToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            int sonuc;
            string mesaj;
            sonuc = Convert.ToInt32(txtBirinciSayı.Text) +
                Convert.ToInt32(txtİkinciSayı.Text);
            MessageBox.Show(sonuc.ToString());
        }
    }
}
