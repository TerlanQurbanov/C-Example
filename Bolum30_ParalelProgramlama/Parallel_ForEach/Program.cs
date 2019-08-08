using System;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adsoyad = { "Talha", "Sümeyye", "Azra", "Murat" };
            Parallel.ForEach(adsoyad, i =>
            {
                Console.WriteLine(i);
            }
            );
            Console.ReadLine();

        }
    }
}
