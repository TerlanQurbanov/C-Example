using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_iciceFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 20, i =>
            {
                Parallel.For(0, 10, j => Console.WriteLine
              (i.ToString(), j.ToString()));
            });
            Console.ReadLine();
        }
    }
}
