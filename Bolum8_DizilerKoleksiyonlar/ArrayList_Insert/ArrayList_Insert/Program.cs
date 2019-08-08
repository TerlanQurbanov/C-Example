using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList isimler = new ArrayList();
            isimler.Add("Hasan");
            isimler.Add("Murat");
            isimler.Add("Talha");
            isimler.Add("Onur");
            isimler.Insert(0, "Sümeyye");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.ReadKey();
        }
    }
}
