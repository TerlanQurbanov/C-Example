using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SayidanEnbuyugu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3;
            Console.WriteLine("1. Notu Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Notu Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Notu Giriniz: ");
            sayi3 = Convert.ToInt32((Console.ReadLine()));
            if ((sayi1 > sayi2) & (sayi1 > sayi3))
                Console.WriteLine("Sayılardan en büyüğü Sayı1= " + sayi1);
            else if ((sayi2 > sayi1) & (sayi2 > sayi3))
                Console.WriteLine("Sayılardan en büyüğü Sayı2= " + sayi2);
            else if ((sayi1 < 0) | (sayi2 < 0) | (sayi3 < 0))
                Console.WriteLine("Sayılar 0'dan küçük olmamalı!");
            else
                Console.WriteLine("Sayılardan en büyüğü Sayı3= " + sayi3);        
            Console.ReadKey();
        }
    }
}
