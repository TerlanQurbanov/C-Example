using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList bilgi = new ArrayList();
            bilgi.Add("Talha");
            bilgi.Add(123);
            bilgi.Add("a");
            Console.WriteLine(bilgi[bilgi.Count - 1]);
            bilgi.RemoveAt(bilgi.Count - 1);
            Console.WriteLine(bilgi[bilgi.Count - 1]);
            Console.ReadKey();
        }
    }
}
