using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bilgi = new Dictionary<string, int>()
            {
                {"Talha AKTAŞ", 12},
                {"Sümeyye AKTAŞ", 9},
                {"Murat AKTAŞ" , 19},
                {"Mehmet GÖKMEN", 21}
            };
            //var sırala = from eleman in bilgi orderby eleman.Key descending select eleman.Key;
            var arama = bilgi.Where(eleman => eleman.Key.StartsWith("M"))
                   .Select(eleman => eleman.Key); 
            foreach (string anahtar in arama)
                Console.WriteLine(anahtar);
            Console.ReadLine();
        }
    }
}
