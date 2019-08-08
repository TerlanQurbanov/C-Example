using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notu Giriniz");
            byte not_degeri = Convert.ToByte
                (Console.ReadLine());
            if (not_degeri >= 45)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }
            Console.ReadKey();
        }
    }
}
