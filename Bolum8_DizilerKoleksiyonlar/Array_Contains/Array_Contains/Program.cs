using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string aranan;
            string[] isimler = new string[4];
            isimler[0] = "Hasan";
            isimler[1] = "Murat";
            isimler[2] = "Talha";
            isimler[2] = "Onur";

            Console.Write("Aranan değeri giriniz:");
            aranan = Console.ReadLine();
            if (isimler.Contains(aranan) == false)
            {
                Console.Write("Aranan değer bulunamadı");
            }
            else
            {
                Console.Write("Aranan eleman bulundu");
            }
            Console.ReadKey();            
        }
    }
}
