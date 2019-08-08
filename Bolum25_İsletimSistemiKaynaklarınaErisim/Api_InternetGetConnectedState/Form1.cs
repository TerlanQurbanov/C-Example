using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Api_InternetGetConnectedState
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        extern static bool InternetGetConnectedState(ref 
            InternetGetConnectedStateFlags Description, int ReservedValue);
        [Flags]
        public enum InternetGetConnectedStateFlags
        {
            INTERNET_CONNECTION_MODEM = 0x01,
            INTERNET_CONNECTION_LAN = 0x02,
            INTERNET_CONNECTION_PROXY = 0x04,
            INTERNET_CONNECTION_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }
        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            InternetGetConnectedStateFlags flags = 0;
            bool baglantı = InternetGetConnectedState(ref flags, 0);
            if (baglantı)
                MessageBox.Show("İnternet bağlantısı var.");
            else
                MessageBox.Show("İnternet bağlantısı yok.");
        }
    }
}
