using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_ResetColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Adınızı Girin: ");            
            Console.ResetColor();
            Console.WriteLine("Soyadınızı Girin: ");
            Console.ReadKey();
        }
    }
}
