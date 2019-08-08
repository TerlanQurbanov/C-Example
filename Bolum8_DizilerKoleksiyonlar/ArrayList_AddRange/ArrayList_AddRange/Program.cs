using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_AddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList diller = new ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");

            ArrayList digerdiller = new ArrayList();
            digerdiller.Add("Python");
            digerdiller.Add("F#");
            digerdiller.Add("C++");

            diller.AddRange(digerdiller);
            foreach (string eleman in diller)
                Console.WriteLine(eleman);
            Console.ReadKey();
        }
    }
}
