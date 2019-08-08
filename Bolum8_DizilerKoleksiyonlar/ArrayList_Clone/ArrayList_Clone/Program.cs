using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList diller = new ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");

           // ArrayList digerdiller = diller;
            ArrayList digerdiller = new ArrayList();
            digerdiller = (ArrayList)diller.Clone();

            diller.Remove("ASP.Net");

            Console.WriteLine(digerdiller[0]);
            Console.WriteLine(digerdiller[1]);
            Console.WriteLine(digerdiller[2]);
            Console.ReadKey();
        }
    }
}
