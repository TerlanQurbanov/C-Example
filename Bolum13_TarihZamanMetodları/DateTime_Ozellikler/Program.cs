using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Ozellikler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dogum_gunu = new DateTime(2002, 11, 13);
            //Console.WriteLine(dogum_gunu.ToLongDateString());
            //Console.WriteLine(dogum_gunu.ToShortDateString());
            //Console.WriteLine(dogum_gunu.Year);
            //Console.WriteLine(dogum_gunu.Month);
            //Console.WriteLine(dogum_gunu.Day);
            DateTime zaman = new DateTime(2002, 11, 13, 10, 55, 14);
            //Console.WriteLine(zaman.ToLongTimeString());
            //Console.WriteLine(zaman.ToShortTimeString());
            Console.WriteLine(zaman.Hour);
            Console.WriteLine(zaman.Minute);
            Console.WriteLine(zaman.Second);
            Console.ReadKey();
        }
    }
}
