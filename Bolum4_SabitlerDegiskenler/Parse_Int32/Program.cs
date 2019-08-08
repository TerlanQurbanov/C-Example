using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Int32
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 = "123";
            string sayi2 = null;
            string sayi3 = "123.45";
            string sayi4 = "1234567891011121314151617181920";
            Console.WriteLine(Int32.Parse(sayi1));
            Console.WriteLine(Int32.Parse(sayi2));
            Console.WriteLine(Int32.Parse(sayi3));
            Console.WriteLine(Int32.Parse(sayi4));
            Console.ReadLine();
        }
    }
}
