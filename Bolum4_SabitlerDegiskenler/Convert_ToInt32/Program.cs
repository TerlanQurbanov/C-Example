using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_ToInt32
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 = "123";
            string sayi2 = null;
            string sayi3 = "123.45";
            string sayi4 = "1234567891011121314151617181920";
            Console.WriteLine(Convert.ToInt32(sayi1));
            Console.WriteLine(Convert.ToInt32(sayi2));
            Console.WriteLine(Convert.ToInt32(sayi3));
            Console.WriteLine(Convert.ToInt32(sayi4));
            Console.ReadLine();
        }
    }
}
