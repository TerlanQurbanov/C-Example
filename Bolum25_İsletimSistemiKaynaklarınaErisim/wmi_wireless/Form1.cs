using System;
using System.Windows.Forms;
using System.Management;
using System.Text;
namespace wmi_wireless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ManagementClass cpu = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection cpu_bilgi = cpu.GetInstances();
            foreach (ManagementObject m in cpu_bilgi)
            {
                if ( m.Properties["NetConnectionID"].Value!=null)
                    listBox1.Items.Add("İsmi : " +
                        m.Properties["NetConnectionID"].Value);             
            }              
    
        }

       
    }
}
