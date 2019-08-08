using System;
using System.Windows.Forms;
using System.Text;
namespace Polymorphism
{
    public class snf_Temel
    {       
        public virtual void mtd_mesaj(string icerik)
        {
            MessageBox.Show(icerik);
        }
    }
    public class snf_Turemis : snf_Temel
    {        
        //public void mtd_mesaj(string icerik, bool buyukharf)
        public override void mtd_mesaj(string icerik)
        {
            //if (buyukharf == true)
            //{
             MessageBox.Show(icerik.ToUpper());
            //}
        }
    }
}
