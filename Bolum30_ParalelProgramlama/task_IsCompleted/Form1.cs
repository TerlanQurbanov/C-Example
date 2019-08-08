using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
namespace task_IsCompleted
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
            Task task1 = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 30; i++)
                {
                    Thread.Sleep(500);
                    label1.Text = i + " ";
                }
            })
            .ContinueWith((task2) =>
            {
                for (int j = 1; j <= 30; j++)
                {
                    Thread.Sleep(500);
                    label2.Text = j + " ";
                }
                if (task2.IsCompleted == true)
                    MessageBox.Show("Sayım İşlemi Tamamlandı");
            });

        }
    }
}
