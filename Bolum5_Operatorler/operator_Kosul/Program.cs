using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_Kosul
{
    class Program
    {
        static void Main(string[] args)
        {
            string durum;
            Console.WriteLine("Çıkmak İstediğinize Emin misiniz? (E, H)");
            durum = Console.ReadLine();
            Console.Write(durum == "E" ? "Güle Güle" : "Çalışmaya Devam");
            Console.ReadLine();
        }
    }
}
