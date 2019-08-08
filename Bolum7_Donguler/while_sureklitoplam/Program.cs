using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_sureklitoplam
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam=0, sayi=0;
            do
            {
                Console.Write("Bir sayı giriniz= ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            while (sayi != 0);
            Console.WriteLine("Sayıların toplamı= " + toplam);
            Console.ReadLine();
        }
    }
}
