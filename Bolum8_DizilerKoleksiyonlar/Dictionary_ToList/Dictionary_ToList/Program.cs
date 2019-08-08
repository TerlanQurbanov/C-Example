using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_ToList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dallar = new Dictionary<string, string>()
            {
                {"Volkan AKTAŞ", "Programlama"},
                {"Bünyamin KARAHAN", "Programlama"},
                {"İrfan MERGAN", "Donanım"},
                {"Hale KATMER", "Web Tasarım"}
            };           
            foreach (var eleman in dallar.Keys.ToList())
                dallar[eleman] = "Programlama";
            foreach (KeyValuePair<string, string> eleman in dallar)
                Console.WriteLine(eleman.Key + " = " + eleman.Value);
            Console.ReadLine();
        }
    }
}
