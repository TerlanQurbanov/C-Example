using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_InterSectWith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("C#");
            list.Add("VB.Net");
            list.Add("ASP.Net");
            list.Add("MVC");
            list.Add("Silverlight");
            HashSet<string> h_set = new HashSet<string>();
            h_set.Add("VB.Net");
            h_set.Add("C#");
            h_set.Add("WPF");
            h_set.IntersectWith(list);
            foreach (string degerler in h_set)
                Console.WriteLine(degerler);
            Console.ReadLine();
        }
    }
}
