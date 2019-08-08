using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_CopyTo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array diller = Array.CreateInstance(typeof(string), 4);
            diller.SetValue("VB.Net", 0);
            diller.SetValue("C#", 1);
            diller.SetValue("ASP.Net", 2);

            ArrayList digerdiller = new ArrayList();
            digerdiller.Add("Python");
            digerdiller.Add("F#");
            digerdiller.Add("C++");

            //digerdiller.CopyTo(diller, 1);
            //digerdiller.CopyTo(0, diller, 0, 0);
            //digerdiller.CopyTo(0, diller, 0, 2);
            //digerdiller.CopyTo(0, diller, 1, 2);
            digerdiller.CopyTo(1, diller, 0, 2);
            foreach (string eleman in diller)
                Console.WriteLine(eleman);
            Console.ReadKey();
        }
    }
}
