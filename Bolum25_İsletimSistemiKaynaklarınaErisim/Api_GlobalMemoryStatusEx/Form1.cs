using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Api_GlobalMemoryStatusEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll")]
        public static extern void GlobalMemoryStatusEx
                  (ref MEMORYSTATUSEX hafıza);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }
        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
            MEMORYSTATUSEX hafıza = new MEMORYSTATUSEX();
            hafıza.dwLength = 64;
            GlobalMemoryStatusEx(ref hafıza);

            textBox1.Text = textBox1.Text + "Kullanılan bellek yüzdesi= " +
                (hafıza.dwMemoryLoad) + "\r\n";
            textBox1.Text = textBox1.Text + "Toplam bellek miktarı= " +
                (hafıza.ullTotalPhys / (1024 * 1024)) + " mb \r\n";
            textBox1.Text = textBox1.Text + "Boş bellek miktarı= " +
                (hafıza.ullAvailPhys / (1024 * 1024)) + " mb \r\n";
            textBox1.Text = textBox1.Text + "Toplam page file miktarı= " +
                (hafıza.ullTotalPageFile / (1024 * 1024)) + " mb \r\n";
            textBox1.Text = textBox1.Text + "Boş page file miktarı= " +
                (hafıza.ullAvailPageFile / (1024 * 1024)) + " mb \r\n";
            textBox1.Text = textBox1.Text + "Toplam sanal bellek miktarı= " +
                (hafıza.ullTotalVirtual / (1024 * 1024)) + " mb \r\n";
            textBox1.Text = textBox1.Text + "Boş sanal bellek miktarı= " +
                (hafıza.ullAvailVirtual / (1024 * 1024)) + " mb"; 
        }
    }
}
