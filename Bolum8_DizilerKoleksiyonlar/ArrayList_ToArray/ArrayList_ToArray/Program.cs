using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_ToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList diller = new ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");
            string[] yenidizi = (string[])diller.ToArray(typeof(string));
            foreach (string eleman in yenidizi)
                Console.WriteLine(eleman);
            Console.ReadKey();
        }
    }
}
