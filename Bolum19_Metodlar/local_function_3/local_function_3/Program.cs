using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_function_3
{
    class Program
    {
        static string Mesaj(int okunandeger)
        {
            if (TekCift_LocalFunction(okunandeger))
                return("Sayı çift");
            else
                return ("Sayı tek");
            bool TekCift_LocalFunction(int sayi)
            {
                bool sonuc = false;
                if (sayi % 2 == 0)
                    sonuc = true;
                else
                    sonuc = false;
                return sonuc;
            }               
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Mesaj(sayi));
            Console.ReadKey();
        }
    }
}
