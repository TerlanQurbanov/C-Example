using System;
using System.Windows.Forms;
using System.Management;
namespace wmi_calisan_uygulamalar
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
                ("SELECT * FROM Win32_Process");

            foreach (ManagementObject m in programlar.Get())            
                if (m.Properties["Name"].Value != null)                
                    listBox1.Items.Add(m["Name"].ToString());                                
            
            label1.Text = listBox1.Items.Count +
                " adet uygulama çalışıyor";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher programlar = new ManagementObjectSearcher
                ("SELECT * FROM Win32_Process WHERE Name = '" +
                listBox1.SelectedItem.ToString() + "'");

            foreach (ManagementObject m in programlar.Get())
                if (m["Name"].ToString() == listBox1.SelectedItem.ToString())
                {
                    if (m.Properties["ExecutablePath"].Value != null)   
                        label2.Text=(m["ExecutablePath"].ToString());
                }                  
        }
        private void btnSonlandır_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher programlar = new ManagementObjectSearcher
                ("SELECT * FROM Win32_Process WHERE Name = '" +
                listBox1.SelectedItem.ToString() + "'");

            foreach (ManagementObject m in programlar.Get())
                if (m["Name"].ToString() == listBox1.SelectedItem.ToString())                   
                        m.InvokeMethod("Terminate", null);               
        }
    }
}
