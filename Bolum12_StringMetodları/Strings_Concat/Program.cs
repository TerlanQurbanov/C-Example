using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bilgisayar ";
            //string b = "Bölümü";
            Console.WriteLine(string.Concat(a, "Bölümü","deneme"));
            Console.ReadKey();
        }
    }
}
