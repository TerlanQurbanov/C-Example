using System;
using System.Windows.Forms;
using System.Management;
namespace WMI_CPUBilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            //ManagementObjectSearcher cpu = new ManagementObjectSearcher
            //    ("Select Name, NumberOfLogicalProcessors,L2CacheSize From Win32_Processor");
            //foreach (ManagementObject cpu_bilgi in cpu.Get())
            //{                
                //listBox1.Items.Add("İsmi : " + 
                    //(cpu_bilgi["Name"]).ToString());                
                //listBox1.Items.Add("İşlemci Çekirdeği Sayısı : " +
                    //(cpu_bilgi["NumberOfLogicalProcessors"]).ToString());
                //listBox1.Items.Add("L2 Cache Boyutu : " +
                    //(cpu_bilgi["L2CacheSize"]).ToString());
            //}
            ManagementClass cpu = new ManagementClass("Win32_Processor");
            ManagementObjectCollection cpu_bilgi = cpu.GetInstances();
            foreach (ManagementObject m in cpu_bilgi)  
            {
                listBox1.Items.Add("İsmi : " +m.Properties["Name"].Value.ToString());
                listBox1.Items.Add("İşlemci Çekirdeği Sayısı : " + m.Properties["NumberOfLogicalProcessors"].Value.ToString());
                listBox1.Items.Add("L2 Cache Boyutu : " + m.Properties["L2CacheSize"].Value.ToString());
            }              
        }
    }
}
