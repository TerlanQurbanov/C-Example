using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_TekCift
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayıyı girin");
            sayi = Console.Read();
            if (sayi % 2 == 0)
                Console.WriteLine("Sayı Çift");
            else
                Console.WriteLine("Sayı Tek");
            Console.ReadKey();
        }
    }
}
