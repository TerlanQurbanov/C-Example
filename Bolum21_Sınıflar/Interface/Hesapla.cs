using System;
using System.Text;
namespace Interface
{
    interface KDVliSonuc
    {
        double kdvoran { get; set; }
        int adet { get; set; }
        int birimfiyat { get; set; }        
        double kdvliislem();       
    }
    interface KDVsizSonuc
    {
        int adet { get; set; }
        int birimfiyat { get; set; }
        double kdvsizislem();
    }
    public class Turemis_Sınıf :KDVliSonuc,KDVsizSonuc
    {
        public double kdvoran { get; set; }
        public int adet { get; set; }
        public int birimfiyat { get; set; }               
        public double kdvliislem()
        {
            double sonuc = (adet*birimfiyat)+((adet*birimfiyat)*kdvoran);
            return (sonuc);
        }
        public double kdvsizislem()
        {
            double sonuc = adet * birimfiyat ;
            return (sonuc);
        }
    }
}
