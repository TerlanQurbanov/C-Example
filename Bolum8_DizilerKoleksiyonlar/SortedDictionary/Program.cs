using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> bilgi = new SortedDictionary<string, int>()
            {
                {"Talha AKTAŞ", 10},
                {"Sümeyye AKTAŞ", 7},
                {"Murat AKTAŞ" , 17},
                {"Azra UNCU", 4}
            };
            foreach (var eleman in bilgi)
                Console.WriteLine(eleman);
            Console.ReadLine();

        }
    }
}
