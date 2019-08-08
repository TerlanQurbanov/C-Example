using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Matching_Var_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "deneme";
            if (obj is var str)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
