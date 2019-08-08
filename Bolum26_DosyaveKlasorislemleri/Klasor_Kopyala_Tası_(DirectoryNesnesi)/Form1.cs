using System;
using System.IO;
using System.Windows.Forms;

namespace Klasor_Kopyala_Tası__DirectoryNesnesi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            DirectoryInfo kaynak_klasor = new DirectoryInfo(txtKaynak.Text);
            DirectoryInfo hedef_klasor = new DirectoryInfo(txtHedef.Text);

            if (!hedef_klasor.Exists)
                Directory.CreateDirectory(txtHedef.Text);
            foreach (FileInfo fi in kaynak_klasor.GetFiles())
                fi.CopyTo(Path.Combine(hedef_klasor.ToString(), fi.Name), true);
        }
        private void btnTası_Click(object sender, EventArgs e)
        {
            Directory.Move(txtKaynak.Text, txtHedef.Text);
        }
    }
}
