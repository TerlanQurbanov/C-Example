using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Nesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listemiz = new List<string>();
            listemiz.Add("VB.NET");
            listemiz.Add("C#");
            listemiz.Add("ASP.NET");
            Console.WriteLine(listemiz[listemiz.Count - 1]);
            listemiz.RemoveAt(listemiz.Count - 1);
            Console.WriteLine(listemiz[listemiz.Count - 1]);
            Console.ReadLine();
        }
    }
}
