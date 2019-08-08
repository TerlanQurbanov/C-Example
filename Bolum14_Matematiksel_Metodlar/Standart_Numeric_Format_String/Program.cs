using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_Numeric_Format_String
{
    class Program
    {
        static void Main(string[] args)
        {
            object rakam;
            rakam = 24.495;
            rakam = string.Format("{0:C}", rakam);
            Console.WriteLine(rakam);

            rakam = -12345;
            rakam = string.Format("{0:D4}", rakam);
            Console.WriteLine(rakam);

            rakam = 12345;
            rakam = string.Format("{0:F2}", rakam);
            Console.WriteLine(rakam);

            rakam = 0.24595;
            rakam = string.Format("{0:P2}", rakam);
            Console.WriteLine(rakam);
            Console.ReadKey();
        }
    }
}
