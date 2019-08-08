using System;
using System.Threading;
using System.Windows.Forms;

namespace thread_basla_bitir_durdur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread kanal1, kanal2;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            kanal1 = new Thread(new ThreadStart(sayici1));
            kanal2 = new Thread(new ThreadStart(sayici2));
            CheckForIllegalCrossThreadCalls = false;

            kanal1.Start();
            kanal2.Start();  
        }
        private void sayici1()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label1.Text = i + " ";
            }
        }
        private void sayici2()
        {
            kanal1.Join();
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label2.Text = i + " ";
                if (i == 15)
                    Thread.Sleep(3000);
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (btnDurdur.Text == "Durdur")
            {
                btnDurdur.Text = "Devam Et";
                kanal1.Suspend();
                kanal2.Suspend();
            }
            else
            {
                btnDurdur.Text = "Durdur";
                kanal1.Resume();
                kanal2.Resume();
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            try
            {
                kanal1.Abort();
                kanal2.Abort();
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show(ex.ToString(), "Hata");
            }
        }

    }
}
