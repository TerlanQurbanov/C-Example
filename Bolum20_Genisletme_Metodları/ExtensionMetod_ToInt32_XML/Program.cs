using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetod_ToInt32_XML
{
    static class Extensions
    {
        /// <summary>
        /// ToInt32 metodu parametre olarak gelen bir değeri
        /// Int32 veri türüne dönüştürür.
        /// </summary>
        public static int ToInt32(this string deger)
        {
            return Convert.ToInt32(deger);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1, sayi2;
            Console.WriteLine("Birinci notu giriniz");
            sayi1 = Console.ReadLine();
            Console.WriteLine("İkinci notu giriniz");
            sayi2 = Console.ReadLine();
            Console.WriteLine("Ortalama= " + (sayi1.ToInt32() + sayi2.ToInt32()) / 2);
            Console.ReadLine();
        }
    }
}
