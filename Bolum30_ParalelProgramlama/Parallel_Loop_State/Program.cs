using System;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Loop_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 20, (i, durum) =>
            {
                if (i == 10)
                    durum.Break();
                else
                    Console.WriteLine(i);
            });
            Console.ReadLine();
        }
    }
}
