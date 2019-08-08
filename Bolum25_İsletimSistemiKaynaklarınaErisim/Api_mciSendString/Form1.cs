using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.IO;
namespace Api_mciSendString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command,
            StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        const int MM_MCINOTIFY = 953;
        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txtYol.Enabled)
            {
                foreach (string bulunandosya in
                        Directory.GetFiles(txtYol.Text,
                        "*.wmv", SearchOption.TopDirectoryOnly))
                    listBox1.Items.Add(bulunandosya);
            }
        }
        string komut_string;
        private void btnOynat_Click(object sender, EventArgs e)
        {
            komut_string = "Open " + listBox1.SelectedItem +
            " type mpegvideo alias Video";
            mciSendString(komut_string, null, 0, IntPtr.Zero);

            if (btnOynat.Text == "Oynat")
            {
                btnOynat.Text = "Durdur";
                komut_string = "Play Video";
                mciSendString(komut_string, null, 0, IntPtr.Zero);
            }
            else
            {
                btnOynat.Text = "Oynat";
                komut_string = "Pause Video";
                mciSendString(komut_string, null, 0, IntPtr.Zero);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            komut_string = "Close Video";
            mciSendString(komut_string, null, 0, IntPtr.Zero);
        }
    }
}
