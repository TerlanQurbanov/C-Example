using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_GetRange
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList diller = new ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("Visual C++");
            diller.Add("ASP.Net");

            ArrayList digerdiller = diller.GetRange(0, 2);
            foreach (string eleman in digerdiller)
                Console.WriteLine(eleman);
            Console.ReadKey();
        }
    }
}
