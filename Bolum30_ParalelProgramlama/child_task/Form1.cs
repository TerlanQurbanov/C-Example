using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
namespace child_task
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
            Task parent = Task.Factory.StartNew(() =>
            {
                Task.Factory.StartNew(() => //Parent Task
                {
                    MessageBox.Show("Parent task saymaya başladı");
                    for (int i = 1; i <= 30; i++)
                    {
                        Thread.Sleep(500);
                        label1.Text = i + " ";
                    }
                });
                Task.Factory.StartNew(() => // Child task
                {
                    MessageBox.Show("Child task saymaya başladı");
                    for (int j = 1; j <= 30; j++)
                    {
                        Thread.Sleep(500);
                        label2.Text = j + " ";
                    }
                }, TaskCreationOptions.AttachedToParent);
            });

        }
    }
}
