using System;
using System.Text;
namespace Extension
{
    static class Extensions
    {
        /// <summary>
        /// ToUpper metodu parametre olarak gelen bir değeri
        /// büyük harfe dönüştürür.
        /// </summary>   
        public static string ToUpper(this string icerik)
        {
            return icerik.ToUpper();
        }
    }
}
namespace Extension_Method_ToUpper
{
    using Extension;
    class Program
    {
        static void Main(string[] args)
        {
            string yazi;
            Console.WriteLine("Yazıyı giriniz");
            yazi = Console.ReadLine();
            Console.WriteLine("Büyük harfe çevrilmiş hali= " +
                        yazi.ToUpper());
            Console.ReadLine();
        }
    }
}
