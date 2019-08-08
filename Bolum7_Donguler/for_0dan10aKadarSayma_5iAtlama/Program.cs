using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_0dan10aKadarSayma_5iAtlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                if (i == 5) i++;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
