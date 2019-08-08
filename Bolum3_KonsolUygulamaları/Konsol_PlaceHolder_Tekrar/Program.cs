using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_PlaceHolder_Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Girin");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaşınızı Girin");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adınız {0} Yaşınız {1}. Uygulamamıza hoş geldiniz {0}"
                ,ad, yas );
            Console.ReadKey();
        }
    }
}
