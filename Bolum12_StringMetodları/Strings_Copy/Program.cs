using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            a = "Bilgisayar";
            b = string.Copy(a);
            Console.WriteLine(b);
            Console.ReadKey();            
        }
    }
}
