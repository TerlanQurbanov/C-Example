using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_PlaceHolder_Hizalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Girin");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınızı Girin");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Adınız |{0,-10}| Soyadınız |{1,-4}| Yaşınız |{2,10}|", 
                ad, soyad, yas);
            Console.ReadLine();
        }
    }
}
