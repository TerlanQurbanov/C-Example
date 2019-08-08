using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Api_waveOutSetVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern uint waveOutGetVolume(IntPtr hwo, uint dwVolume);
        [DllImport("winmm.dll", SetLastError = true, CallingConvention =
        CallingConvention.Winapi)]
        public static extern int waveOutSetVolume(IntPtr uDeviceID,
        uint dwVolume);
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int yenises = ((ushort.MaxValue / 10) * trackBar1.Value);
            uint sonucses = (((uint)yenises & 0xffff) | ((uint)yenises << 16));
            waveOutSetVolume(IntPtr.Zero, sonucses);  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            uint ses = 0;
            waveOutGetVolume(IntPtr.Zero, ses);
            ushort sesduzeyi = Convert.ToUInt16((ses & 0xffff));
            trackBar1.Value = sesduzeyi / (ushort.MaxValue / 10);
        }
    }
}
