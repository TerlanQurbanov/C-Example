using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.AccessControl;
namespace Registry_Delete_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey
                ("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            listBox1.Items.Clear();
            foreach (string deger_adı in anahtar.GetValueNames())
                listBox1.Items.Add(deger_adı);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey
                ("Software\\Microsoft\\Windows\\CurrentVersion\\Run",
                RegistryKeyPermissionCheck.ReadWriteSubTree,
                RegistryRights.SetValue);
            anahtar.SetValue("Hesap Makinesi",
                "C:\\Windows\\System32\\calc.exe",
                RegistryValueKind.String);
            anahtar.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            RegistryKey anahtar = Registry.CurrentUser.OpenSubKey
                ("Software\\Microsoft\\Windows\\CurrentVersion\\Run",
                RegistryKeyPermissionCheck.ReadWriteSubTree,
            RegistryRights.SetValue);
            anahtar.DeleteValue("Hesap Makinesi", false);
            anahtar.Close();
        }
    }
}
