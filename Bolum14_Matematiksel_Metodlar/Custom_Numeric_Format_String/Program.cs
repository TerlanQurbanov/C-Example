using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Numeric_Format_String
{
    class Program
    {
        static void Main(string[] args)
        {
            object rakam;
            rakam = 123456;
            rakam = string.Format("{0:###,###}", rakam);
            Console.WriteLine(rakam);

            rakam = 123.4567;
            rakam = string.Format("{0:###.##}", rakam);
            Console.WriteLine(rakam);

            rakam = 0.24595;
            rakam = string.Format("{0:%#0.00}", rakam);
            Console.WriteLine(rakam);

            rakam = 0.24595;
            rakam = string.Format("{0:‰#0.00}", rakam);
            Console.WriteLine(rakam);
            Console.ReadKey();
        }
    }
}
