using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Matching_Constant_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            object sayi = 2;
            if (sayi is int i)
                Console.WriteLine(i + 3);
            else if (sayi is null)
                Console.WriteLine("Boş değer");
            else
                Console.WriteLine("Sayi int değil");           
            Console.ReadLine();
        }
    }
}
