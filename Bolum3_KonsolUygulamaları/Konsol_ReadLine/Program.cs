using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            String ad;
            Console.Write("Adınızı Girin: ");
            ad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(ad);
            Console.ReadKey();

        }
    }
}
