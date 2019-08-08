using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_KeyInfo_TusBilgisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Tuşa Basınız");
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            Console.WriteLine(KeyInfo.Key.ToString() + " tuşuna bastınız");
            Console.ReadLine();
        }
    }
}
