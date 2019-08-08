using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = new DateTime(2014, 06, 15);
            TimeSpan fark = DateTime.Now.Subtract(tarih);

            Console.WriteLine("Bugün = " +
                DateTime.Now.ToLongDateString());
            Console.WriteLine("Bugünün tarihi ile " +
                tarih.ToLongDateString() + 
                " arasındaki fark = " + fark.Days +" gün");
            Console.ReadKey();
        }
    }
}
