using System;
using System.Threading.Tasks;
using System.Text;
namespace Parallel_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
            });
            Console.ReadLine();   
        }
    }
}
