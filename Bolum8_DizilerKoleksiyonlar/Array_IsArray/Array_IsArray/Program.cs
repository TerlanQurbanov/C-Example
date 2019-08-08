using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_IsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] okulturu = { "Anadolu", "Meslek", "Teknik" };
            string ad = "Volkan";
            Type tip;
            tip = okulturu.GetType();
            Console.WriteLine(tip.IsArray);
            tip = ad.GetType();
            Console.WriteLine(tip.IsArray);
            Console.ReadKey();
        }
    }
}
