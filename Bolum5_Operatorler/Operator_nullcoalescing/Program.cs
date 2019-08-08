using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_nullcoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adı = null;
            string adı = "Azra";
            string durum = adı ?? "Adı girilmedi";
            Console.WriteLine(durum);
            Console.ReadLine();
        }
    }
}
