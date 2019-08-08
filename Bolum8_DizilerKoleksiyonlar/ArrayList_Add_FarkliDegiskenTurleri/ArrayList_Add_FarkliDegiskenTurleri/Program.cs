using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Add_FarkliDegiskenTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList bilgi = new ArrayList();
            bilgi.Add("Talha");
            bilgi.Add(123);
            bilgi.Add("a");
            Console.Write(bilgi[1]);
            Console.ReadKey();
        }
    }
}
