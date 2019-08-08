using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Resize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adsoyad = new string[2];

            adsoyad[0] = "Talha";
            adsoyad[1] = "Sümeyye";

            Console.WriteLine("Dizinin İlk Elemanının Değeri = " + adsoyad[0]);

            adsoyad = new string[3];

            //Array.Resize(ref adsoyad, 3);

            adsoyad[2] = "Ömer";

            Console.WriteLine("Dizinin İlk Elemanının Değeri = " + adsoyad[0]);
            Console.WriteLine("Dizinin Son Elemanının Değeri = " + adsoyad[2]);
            Console.ReadKey();

        }
    }
}
