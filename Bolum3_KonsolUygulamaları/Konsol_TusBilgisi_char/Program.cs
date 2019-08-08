using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_TusBilgisi_char
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            Console.Write("Bir tuşa basarak ardından enter'a basınız: ");
            karakter = (char)Console.Read(); 
            Console.WriteLine("Basılan tuş: " + karakter);
            Console.ReadKey();
        }
    }
}
