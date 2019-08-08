using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_KeyInfo_TusBilgisi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            Console.Write("Adınızı Girin=");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Girin=");
            soyad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine
              ("Ekrana yazdırmak için F2, Çıkmak için ESC tuşuna basınız");
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                System.Environment.Exit(0);
            }
            else if (KeyInfo.Key == ConsoleKey.F2)
            {
                Console.Write(ad + " " + soyad);
                Console.ReadKey();
            }

        }
    }
}
