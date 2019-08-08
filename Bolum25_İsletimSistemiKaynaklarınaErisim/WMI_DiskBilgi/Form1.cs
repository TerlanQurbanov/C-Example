using System;
using System.Windows.Forms;
using System.Management;
namespace WMI_DiskBilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher disk = new ManagementObjectSearcher
                ("Select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");
            foreach (ManagementObject disk_bilgi in disk.Get())
            {
                listBox1.Items.Add("Sürücü İsmi: " + 
                    disk_bilgi["Name"].ToString());
                listBox1.Items.Add("Boyutu (gb) : " + 
                    string.Format("{0:00.0}", 
                    Convert.ToDouble(disk_bilgi["Size"]) 
                    / (1024 * 1024 * 1024)).ToString());
                listBox1.Items.Add("Boş Alan (gb) : " + 
                    string.Format("{0:00.0}",
                    Convert.ToDouble(disk_bilgi["FreeSpace"]) 
                    / (1024 * 1024 * 1024)).ToString());            
            }
        }
    }
}
