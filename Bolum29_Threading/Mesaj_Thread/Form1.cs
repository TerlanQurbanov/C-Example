using System;
using System.Threading;
using System.Windows.Forms;

namespace Mesaj_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDongu_Click(object sender, EventArgs e)
        {
            //Dongu();
            Thread kanal1 = new Thread(Dongu);
            kanal1.Start();
        }
        private void Dongu()
        {
            decimal i = default(decimal);
            for (i = 0; i <= 1000000000; i++)
            {
            }
            MessageBox.Show("İşlem Bitti");
        }
        private void btnMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıkladın");
        }

    }
}
