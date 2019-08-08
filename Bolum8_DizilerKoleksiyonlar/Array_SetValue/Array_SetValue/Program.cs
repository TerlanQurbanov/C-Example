using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_SetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Array okulturleri = Array.CreateInstance(typeof(string), 3);
            okulturleri.SetValue("Endüstri Meslek", 0);
            okulturleri.SetValue("Teknik", 1);
            okulturleri.SetValue("Anadolu Teknik", 2);

            Console.Write(okulturleri.GetValue(2));
            Console.ReadKey();

        }
    }
}
