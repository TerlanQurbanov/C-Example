using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_FixedSize
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
            ArrayList yeniisimler = ArrayList.FixedSize(isimler);
            //yeniisimler.Insert(0, "Sümeyye");
            yeniisimler[0] = "Sümeyye";
            Console.WriteLine(yeniisimler[0]);
            Console.WriteLine(yeniisimler[1]);
            Console.ReadKey();
        }
    }
}
