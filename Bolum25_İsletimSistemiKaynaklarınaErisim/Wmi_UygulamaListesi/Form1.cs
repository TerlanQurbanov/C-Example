using System;
using System.Windows.Forms;
using System.Management;
namespace Wmi_UygulamaListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ManagementObjectSearcher programlar = new ManagementObjectSearcher
                ("SELECT * FROM Win32_Product");
            
            foreach (ManagementObject m in programlar.Get())            
                if (m.Properties["Name"].Value != null)
                    listBox1.Items.Add(m["Name"].ToString());
            label1.Text = listBox1.Items.Count + 
                " adet program yüklü";
        }
        private void btnKaldır_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher programlar = new ManagementObjectSearcher                
                ("SELECT * FROM Win32_Product WHERE Name = '" + 
                listBox1.SelectedItem.ToString() + "'");

            foreach (ManagementObject m in programlar.Get())                    
                if (m["Name"].ToString() == listBox1.SelectedItem.ToString())
                {
                    //object sonuc = m.InvokeMethod("Uninstall", null);
                    //MessageBox.Show(Convert.ToBoolean(sonuc).ToString());
                    //if(Convert.ToBoolean(sonuc)==false)
                    try
                    {
                        m.InvokeMethod("Uninstall", null);
                        MessageBox.Show(listBox1.SelectedItem.ToString() + 
                            " uygulaması başarıyla kaldırıldı");
                    }
                    catch
                    {
                        MessageBox.Show(listBox1.SelectedItem.ToString() + 
                            " uygulaması kaldırılamadı");
                    }
                }            
        }
    }
}
