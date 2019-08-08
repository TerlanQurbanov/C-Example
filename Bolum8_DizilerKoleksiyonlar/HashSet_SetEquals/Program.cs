using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SetEquals
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
            list.Add("C#");  
            HashSet<string> h_set = new HashSet<string>();
            h_set.Add("VB.Net");
            h_set.Add("C#");
            h_set.Add("ASP.Net");
            h_set.Add("MVC");
            if (h_set.SetEquals(list))
                Console.WriteLine("Hashset, List'e eşit");
            else
                Console.WriteLine("Hashset, List'e eşit değil");
            Console.ReadLine();
        }
    }
}
