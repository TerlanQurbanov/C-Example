using System;
using System.Threading;
using System.Windows.Forms;
namespace thread_sleep_delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int j, k;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            Thread kanal1 = new Thread(new ThreadStart(sayici1));
            Thread kanal2 = new Thread(new ThreadStart(sayici2));
            CheckForIllegalCrossThreadCalls = false;

            kanal1.Start();
            kanal2.Start();
        }
        private void sayici1()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label1.Invoke(new sayici1_delegate(yeni_sayici1));
            }
        }
        private void sayici2()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label2.Invoke(new sayici2_delegate(yeni_sayici2));
                if (i == 15)
                    Thread.Sleep(3000);
            }
        }
        private delegate void sayici1_delegate();
        private void yeni_sayici1()
        {
            j++;
            label1.Text = j + " ";
        }
        private delegate void sayici2_delegate();
        private void yeni_sayici2()
        {
            k++;
            label2.Text = k + " ";
        }

    }
}
