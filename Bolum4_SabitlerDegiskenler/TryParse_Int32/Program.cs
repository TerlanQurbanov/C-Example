using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_Int32
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 = "123";
            string sayi2 = null;
            string sayi3 = "123.45";
            string sayi4 = "1234567891011121314151617181920";
            int s1;
            int s2;
            int s3;
            int s4;
            Console.WriteLine(Int32.TryParse(sayi1, out s1));
            Console.WriteLine(Int32.TryParse(sayi2, out s2));
            Console.WriteLine(Int32.TryParse(sayi3, out s3));
            Console.WriteLine(Int32.TryParse(sayi4, out s4));
            Console.ReadLine();
        }
    }
}
