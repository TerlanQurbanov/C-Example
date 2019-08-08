using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
            // Konsol ekranında 0 değeri görünür.
            //while (i > 10);
            Console.ReadLine();
        }
    }
}
