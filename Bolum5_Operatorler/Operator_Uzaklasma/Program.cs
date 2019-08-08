using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Uzaklasma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (i-- > 0)
            {
                Console.WriteLine("i = {0}", i);
            }
            Console.ReadLine();
        }
    }
}
