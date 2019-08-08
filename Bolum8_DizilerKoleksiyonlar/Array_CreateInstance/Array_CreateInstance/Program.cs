using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_CreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Array okulturu = Array.CreateInstance(typeof(string), 3);
            string[] okulturleri = (string[])okulturu;
            okulturleri[0] = ("Endüstri Meslek");
            okulturleri[1] = ("Teknik");
            okulturleri[2] = ("Anadolu Teknik");
            Console.Write(okulturleri[1]);
            Console.ReadKey();
        }
    }
}
