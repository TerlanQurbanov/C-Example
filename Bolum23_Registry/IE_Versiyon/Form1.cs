using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IE_Versiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey anahtar = Registry.LocalMachine.OpenSubKey
                    ("Software\\Microsoft\\Internet Explorer", false);
                string deger = anahtar.GetValue("Version").ToString();
                label1.Text = "Internet Explorer Versiyonu: " + deger;
            }
            catch
            {
                label1.Text = "Bilgisayarda Internet Explorer yüklü değil";
            }        
        }
    }
}
