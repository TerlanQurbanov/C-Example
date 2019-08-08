using System;
using System.Text;
using Extension;
namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1, sayi2;
            Console.WriteLine("Birinci notu giriniz");
            sayi1 = Console.ReadLine();
            Console.WriteLine("İkinci notu giriniz");
            sayi2 = Console.ReadLine();
            Console.WriteLine("Ortalama= " +
                (sayi1.ToInt32() + sayi2.ToInt32()) / 2);
            Console.ReadLine();
        }
    }
}
