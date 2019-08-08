using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_format
{
    class Program
    {
        enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }
        static void Main(string[] args)
        {
            Gunler gunadi;
            gunadi = (Gunler)1;
            Console.WriteLine(gunadi.ToString());
            Console.WriteLine(gunadi.ToString("G"));
            Console.WriteLine(gunadi.ToString("d"));
            Console.WriteLine(gunadi.ToString("F"));
            Console.WriteLine(gunadi.ToString("X"));
            Console.ReadLine();
        }
    }
}
