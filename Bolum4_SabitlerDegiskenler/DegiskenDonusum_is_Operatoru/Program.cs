using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenDonusum_is_Operatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 21.5;
            if (a is int)
                Console.WriteLine("Değer int türündendir.");            
            else
                Console.WriteLine("Değer int türünden değildir.");
            Console.ReadLine();
        }
    }
}
