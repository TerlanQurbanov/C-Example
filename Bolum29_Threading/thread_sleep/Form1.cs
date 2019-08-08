using System;
using System.Threading;
using System.Windows.Forms;
namespace thread_sleep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                label1.Text = i + " ";
            }
        }
        private void sayici2()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label2.Text = i + " ";
                if (i == 15)
                    Thread.Sleep(3000);
            }
        }

    }
}
