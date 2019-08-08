using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Api_SystemParametersInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 uiAction,
            UInt32 uiParam, String pvParam, UInt32 fWinIni);
        private static UInt32 SPI_SETDESKWALLPAPER = 20;
        private static UInt32 SPIF_UPDATEINIFILE = 0x1;
        private String dosyaadi = "c:\\arka_plan.jpg";
        private void btnMasaustunuDegistir_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0,
                dosyaadi, SPIF_UPDATEINIFILE);
        }
    }
}
