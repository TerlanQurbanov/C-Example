using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan zaman = new TimeSpan(11, 52, 21);
            Console.WriteLine("Saat=" + zaman.ToString());
            TimeSpan EklenecekSaat = TimeSpan.FromHours(3);
            Console.WriteLine("Bu saatin 3 saat sonrası = " +
                    zaman.Add(EklenecekSaat));
            Console.ReadKey();   
        }
    }
}
