using System;
using System.Text;
using System.Windows.Forms;
namespace Miras
{
    class Snf_Mesaj
    {
        public Snf_Mesaj()
        {
            MessageBox.Show("Ana Sınıf");
        }

        public void mtd_mesaj(string icerik)
        {
            MessageBox.Show(icerik);
        }
    }
    class snf_mirascı : Snf_Mesaj
    {
        public snf_mirascı()
        {
            MessageBox.Show("Mirasçı Sınıf");
        }
        public void mtd_gelismis_mesaj(string icerik, bool buyukharf)
        {
            if (buyukharf == true)
            {
                mtd_mesaj(icerik.ToUpper());
            }
        }
    }
}
