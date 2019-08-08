using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Api_GetDiskFreeSpaceExA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll", SetLastError = true,
        CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
        out ulong lpFreeBytesAvailable,
        out ulong lpTotalNumberOfBytes,
        out ulong lpTotalNumberOfFreeBytes);
        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
            ulong toplamalan;
            ulong ulasilanbosalan;
            ulong bosalan;
            double alan;

            bool sonuc = GetDiskFreeSpaceEx(txtDiskAdi.Text,
                out ulasilanbosalan, out toplamalan, out bosalan);
            if (!sonuc)            
                throw new System.ComponentModel.Win32Exception();            

            alan = bosalan / (1024 * 1024);
            lblBosAlan.Text = lblBosAlan.Text + " = " +
                alan.ToString() + " mb";

            alan = toplamalan / (1024 * 1024);
            lblToplamAlan.Text = lblToplamAlan.Text +
                " = " + alan.ToString() + " mb";
        }
    }
}
