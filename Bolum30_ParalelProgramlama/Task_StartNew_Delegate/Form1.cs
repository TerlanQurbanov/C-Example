using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
namespace Task_StartNew_Delegate
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
            Task task1 = Task.Factory.StartNew(() =>
            {
                sayici1();
            });
            Task task2 = Task.Factory.StartNew(() =>
            {
                sayici2();
            });
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
