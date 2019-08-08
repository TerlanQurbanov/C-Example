using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //object rakam = 10;
            dynamic rakam = 10;            
            rakam = (double)rakam + 10;
            Console.WriteLine(rakam);
            Console.ReadKey();
        }
    }
}
