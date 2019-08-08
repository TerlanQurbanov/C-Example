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

        /// <summary>
        /// ToUpper metodu parametre olarak gelen bir değerin
        /// kelimelerinin ilk harflerini büyük harfe dönüştürür.
        /// </summary>   
        public static string ToUpper(this string icerik, bool ilkharfbuyuk)
        {
            bool bosluk = true;
            StringBuilder metin = new StringBuilder(icerik.Length);
            foreach (Char karakter in icerik)
            {
                if (bosluk & Char.IsLetter(karakter))
                    metin.Append(Char.ToUpper(karakter));
                else
                    metin.Append(karakter);
                bosluk = Char.IsWhiteSpace(karakter);
            }
            if (ilkharfbuyuk == true)
                return (metin.ToString());
            else
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
            Console.WriteLine("Kelimelerin ilk harfleri büyük hali= " +
                    yazi.ToUpper(true));
            Console.ReadLine();
        }
    }
}
