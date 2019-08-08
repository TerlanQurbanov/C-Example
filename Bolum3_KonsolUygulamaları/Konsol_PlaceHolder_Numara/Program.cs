using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_PlaceHolder_Numara
{
    class Program
    {
        static void Main(string[] args)
        {
            string numara1, numara2;
            Console.Write("1. Numarayı Girin: ");
            numara1 = Console.ReadLine();
            Console.Write("2. Numarayı Girin: ");
            numara2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Girilen Numaralar {0} ve {1}", numara1,
                                numara2);
            Console.ReadKey();

        }
    }
}
