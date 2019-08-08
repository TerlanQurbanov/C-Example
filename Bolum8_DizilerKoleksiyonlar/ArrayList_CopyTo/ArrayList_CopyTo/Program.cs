using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_CopyTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Array diller = Array.CreateInstance(typeof(string), 3);
            diller.SetValue("VB.Net", 0);
            diller.SetValue("C#", 1);
            diller.SetValue("ASP.Net", 2);

            ArrayList digerdiller = new ArrayList();
            digerdiller.Add("Python");
            digerdiller.Add("F#");
            digerdiller.Add("C++");

            digerdiller.CopyTo(diller);

            Console.WriteLine(diller.GetValue(0));
            Console.WriteLine(diller.GetValue(1));
            Console.WriteLine(diller.GetValue(2));
            Console.ReadKey();
        }
    }
}
