using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bilgi = new Dictionary<string, int>()
            {
                ["Talha AKTAŞ"] = 12,
                ["Sümeyye AKTAŞ"] = 9,
                ["Murat AKTAŞ"] = 19,
                ["Mehmet GÖKMEN"] = 21
            };
            Console.WriteLine(bilgi["Talha AKTAŞ"]);
            Console.ReadLine();           
        }
    }
}
