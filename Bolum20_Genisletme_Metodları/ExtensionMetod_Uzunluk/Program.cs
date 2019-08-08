using System;
using System.Text;
namespace Uzunluk_Extension
{
    static class Extensions
    {
        /// <summary>
        /// Parametre olarak girilen içeriğin
        /// uzunluğunu geriye döndürür
        /// </summary>
        public static int uzunluk(this string metin)
        {
            int harfsayisi = 0, noktasayisi, bosluksayisi;
            noktasayisi = metin.Split('.').Length - 1;
            bosluksayisi = metin.Split(' ').Length - 1;
            harfsayisi = metin.Length - (bosluksayisi + noktasayisi);
            return (harfsayisi);
        }

        /// <summary>
        /// Parametre olarak girilen içeriğin
        /// cümle sayısını geriye döndürür
        /// </summary>
        public static int uzunluk(this string metin, bool cumlesay)
        {
            return (metin.Split('.').Length - 1);
        }
    }
}
namespace ExtensionMetod_Uzunluk
{
    using Uzunluk_Extension;
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            Console.WriteLine("Metni Giriniz");
            metin = Console.ReadLine();
            Console.WriteLine("Harf Sayısı= " + metin.uzunluk());
            Console.WriteLine("Cümle Sayısı= " + metin.uzunluk(true));
            Console.ReadLine();
        }
    }
}
