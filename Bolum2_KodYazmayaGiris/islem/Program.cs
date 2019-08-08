using System;
using System.Text;
using veriler;
namespace islem
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenciler = new ogrenci();
            ogrenciler.ad = "Talha Osman";
            ogrenciler.soyad = "AKTAŞ";
            ogrenciler.numara = 15;
            ogrenciler.sınıf = "5-C";

            Console.WriteLine(ogrenciler.ad);
            Console.WriteLine(ogrenciler.soyad);
            Console.WriteLine(ogrenciler.numara);
            Console.WriteLine(ogrenciler.sınıf);

            Console.ReadLine();
        }
    }
}
namespace veriler
{
    struct ogrenci
    {
        public string ad;
        public string soyad;
        public int numara;
        public string sınıf;
    }


}