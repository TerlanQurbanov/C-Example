using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_To_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listemiz = new List<string>();
            listemiz.Add("VB.NET");
            listemiz.Add("C#");
            listemiz.Add("ASP.NET");

            ArrayList yenidizi = new ArrayList(listemiz);

            foreach (string eleman in yenidizi)
                Console.WriteLine(eleman);
            Console.ReadKey();
        }
    }
}
