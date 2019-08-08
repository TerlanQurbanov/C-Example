using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Deconstruction_MultiValue
{
    class Program
    {
        public static (string, bool) SifreKontrol(string sifre)
        {
            bool sifreOnay = false;
            if (sifre == "123")
                sifreOnay = true;
            return (sifre, sifreOnay);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Şifreyi Giriniz:");
            string girilensifre = Console.ReadLine();
            //var sifre = SifreKontrol(girilensifre);
            (string deger, bool onay) = SifreKontrol(girilensifre);
            //Console.WriteLine($"Girilen Şifre={sifre.Item1}. İşlem Sonucu={sifre.Item2}.");
            Console.WriteLine($"Girilen Şifre={deger}. İşlem Sonucu={onay}.");
            Console.ReadLine();
        }
    }
}
