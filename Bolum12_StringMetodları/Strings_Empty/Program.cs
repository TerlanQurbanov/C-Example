using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Empty
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bilgisayar ";
            string b = "Bölümü";
            b = String.Empty;
            Console.WriteLine(string.Concat(a, b));
            Console.ReadKey();
        }
    }
}
