using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Int32_DeclerationExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 = "123";
            string sayi2 = null;
            string sayi3 = "123.45";
            string sayi4 = "1234567891011121314151617181920";
            Console.WriteLine(Int32.TryParse(sayi1, out int s1));
            Console.WriteLine(Int32.TryParse(sayi2, out int s2));
            Console.WriteLine(Int32.TryParse(sayi3, out int s3));
            Console.WriteLine(Int32.TryParse(sayi4, out int s4));
            Console.ReadLine();

        }
    }
}
