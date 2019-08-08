using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
namespace Api_PlaySound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", SetLastError = true)]
        static extern bool PlaySound(string pszSound,
            UIntPtr hmod, uint fdwSound);
        [DllImport("winmm.dll", SetLastError = true)]
        static extern uint waveOutGetNumDevs();

        [Flags]
        public enum SoundFlags
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_MEMORY = 0x0004,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_PURGE = 0x40,
            SND_NOWAIT = 0x00002000,
            SND_ALIAS = 0x00010000,
            SND_ALIAS_ID = 0x00110000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txtYol.Enabled)
            {
                foreach (string bulunandosya in Directory.GetFiles
                    (txtYol.Text, "*.wav", SearchOption.TopDirectoryOnly))
                    listBox1.Items.Add(bulunandosya);
            }
        }
        private void btnCal_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (waveOutGetNumDevs() == 0)
                MessageBox.Show("Ses kartı yok ya da sürücüsü yüklü değil");
            else
            {
                if (checkBox1.Checked)
                {
                    while (i < listBox1.Items.Count)
                    {
                        listBox1.SetSelected(i, true);
                        PlaySound(listBox1.Items[i].ToString(),
                            UIntPtr.Zero, (uint)(SoundFlags.SND_FILENAME |
                            SoundFlags.SND_NOSTOP));
                        i++;
                    }
                }
                else
                    PlaySound(listBox1.SelectedItem.ToString(),
                        UIntPtr.Zero, (uint)(SoundFlags.SND_FILENAME |
                        SoundFlags.SND_ASYNC));
            }
        }
    }
}
