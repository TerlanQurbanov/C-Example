using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan_YeniZaman
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan zaman = new TimeSpan(11, 52, 21);
            Console.WriteLine("Saat=" + zaman.ToString());
            Console.ReadKey();
        }
    }
}
