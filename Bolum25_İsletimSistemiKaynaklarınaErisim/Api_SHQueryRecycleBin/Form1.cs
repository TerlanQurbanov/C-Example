using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Api_SHQueryRecycleBin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("shell32.dll")]
        static extern int SHQueryRecycleBin(string pszRootPath,
            ref SHQUERYRBINFO pSHQueryRBInfo);
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct SHQUERYRBINFO
        {
            public int cbSize;
            public long i64Size;
            public long i64NumItems;
        }

        [DllImport("shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hWnd, string pszRootPath,
           uint dwFlags);
        const int SHERB_NOCONFIRMATION = 0x00000001;
        const int SHERB_NOPROGRESSUI = 0x00000002;
        const int SHERB_NOSOUND = 0x00000004;
        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
            SHQUERYRBINFO shqrbinf = new SHQUERYRBINFO();
            shqrbinf.cbSize = Marshal.SizeOf(typeof(SHQUERYRBINFO));
            int hresult = SHQueryRecycleBin(string.Empty, ref shqrbinf);
            lblSayi.Text = lblSayi.Text + " " +
                (Convert.ToInt32(shqrbinf.i64NumItems).ToString());
            lblBoyut.Text = lblBoyut.Text + " " +
                (Convert.ToInt32(shqrbinf.i64Size /
          (1024 * 1024)).ToString()) + " mb";
        }
        private void btnBosalt_Click(object sender, EventArgs e)
        {
            SHEmptyRecycleBin(IntPtr.Zero, "C:",
                SHERB_NOCONFIRMATION | SHERB_NOPROGRESSUI | SHERB_NOSOUND);
            MessageBox.Show("Geri dönüşüm kutusu boşaltıldı");
        }
    }
}
