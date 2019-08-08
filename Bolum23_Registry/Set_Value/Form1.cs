using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Set_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegerOlustur_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.
                OpenSubKey("Software", true);
            if (anahtar.OpenSubKey("RegistryOrnegi") != null)
            {
                byte tekrar = Convert.ToByte(anahtar.
                    OpenSubKey("RegistryOrnegi", true).GetValue
                    ("CalismaSayisi").ToString());
                anahtar.OpenSubKey("RegistryOrnegi", true).SetValue
                    ("CalismaSayisi", tekrar + 1, RegistryValueKind.String);
            }
            else
            {
                anahtar.CreateSubKey("RegistryOrnegi");
                anahtar.OpenSubKey("RegistryOrnegi", true).SetValue
                    ("CalismaSayisi", 1, RegistryValueKind.String);
                MessageBox.Show("Program Bu Bilgisayarda İlk Defa Çalışıyor");
            }
            anahtar.Close();
        }
    }
}
