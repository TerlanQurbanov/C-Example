using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayList_Add
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
            Console.Write(isimler[2]);
            Console.ReadKey();
        }
    }
}
