using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Parallel_Invoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Parallel.Invoke(
                () =>
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        Thread.Sleep(500);
                        label1.Text = i + " ";
                    }
                },
                () =>
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        Thread.Sleep(500);
                        label2.Text = i + " ";
                    }
                }
                );                  

        }
    }
}
