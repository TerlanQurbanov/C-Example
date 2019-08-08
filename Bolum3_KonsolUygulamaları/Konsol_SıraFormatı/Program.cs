using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_SıraFormatı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}, {1}, {2}", 10, 20, 30);
            Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);            
        }
    }
}
