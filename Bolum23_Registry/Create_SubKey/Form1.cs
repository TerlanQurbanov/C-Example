using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Create_SubKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegerOlustur_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey
                ("Software", true);
            RegistryKey yenianahtar =
                anahtar.CreateSubKey("RegistryOrnegi");
            yenianahtar.SetValue("CalismaSayisi", "1");
            MessageBox.Show("Anahtar oluşturuldu");

        }
    }
}
