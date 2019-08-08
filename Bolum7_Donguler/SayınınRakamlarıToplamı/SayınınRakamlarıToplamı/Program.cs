using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayınınRakamlarıToplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            while (sayi > 0)
            {
                a += sayi % 10;
                sayi /= 10;
            }
            Console.WriteLine("Sayının rakamları toplamı=" + a);
            Console.ReadLine();
        }
    }
}
