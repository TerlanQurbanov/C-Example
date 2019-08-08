using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            try
            {
                for (i = 1; i <= 10000; i++)
                {
                    if (Console.KeyAvailable == false)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        break;
                    }
                    if (i == 10000) i = 1;
                }
            }
            finally
            {
                Console.ReadLine();                
            }
        }
    }
}
