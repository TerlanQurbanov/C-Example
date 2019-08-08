using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Install_Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.LocalMachine.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            foreach (string alt_anahtar_adı in anahtar.GetSubKeyNames())
            {
                RegistryKey alt_anahtar = anahtar.OpenSubKey(alt_anahtar_adı);
                if (alt_anahtar.GetValue("DisplayName") != null)
                    listBox1.Items.Add(alt_anahtar.GetValue("DisplayName")
                  + " --> " + alt_anahtar.GetValue("InstallLocation"));
            }
        }
    }
}
