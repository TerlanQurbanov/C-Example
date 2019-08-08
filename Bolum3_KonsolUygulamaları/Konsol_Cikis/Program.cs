using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_Cikis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çıkmak İstediğinize Emin misiniz? [E/H]");
            string cevap = Console.ReadLine();
            if (cevap == "E")
                Environment.Exit(0);
            else
                Console.WriteLine("Devam");
            Console.ReadLine();

        }
    }
}
