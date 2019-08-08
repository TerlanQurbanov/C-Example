using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Yakinlasma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (-1 < --i)
            {
                Console.WriteLine("i = {0}", i);
            }
            Console.ReadLine();
        }
    }
}
