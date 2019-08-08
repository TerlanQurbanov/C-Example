using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Deconstruction
{
    class Program
    {       
        public static(string deger,bool onay) SifreKontrol(string sifre) 
        {
            bool sifreOnay = false;           
            if (sifre == "123")
                sifreOnay = true;
            var donenDeger = (d: sifre, o: sifreOnay);
            return donenDeger;
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
