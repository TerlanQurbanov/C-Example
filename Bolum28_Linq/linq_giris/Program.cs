using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_giris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1071, 1453, 1799, 1923, 2009, 1988 };
            var sayi1 = from veri in sayilar where veri > 1900 select veri;
            //var sayi1 = from veri in sayilar where veri > 1900 orderby veri ascending select veri;
            foreach (int gelenler in sayi1)
                Console.WriteLine(gelenler.ToString());
            Console.ReadLine();
        }
    }
}
