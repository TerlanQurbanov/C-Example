using System;
using System.Windows.Forms;
using System.Text;
namespace Encapsulation
{
    class snf_encaps
    {
        public readonly double PI = 22 / 7;
        private int x = 1;
        public int x_property
        {
            get { return x; }
        }
        public void A()
        {
            MessageBox.Show("Ben şu an A metodundayım");
        }
        protected void B()
        {
            MessageBox.Show("Ben şu an B metodundayım");
        }
        public void mtd_B_ye_KendiSinifindanErisim()
        {
            B();
        }
    }
    class snf_mtd_Bye_TuretilmisSiniftanErisim : snf_encaps
    {
        private void mtd_Bye_TuretilmisSiniftanErisim()
        {
            B();
        }
    }
    class snf_mtd_Bye_GecersizErisim
    {
        private void ByeErisim()
        {
            //B(); Hata veriyor 
        }
    }
}
