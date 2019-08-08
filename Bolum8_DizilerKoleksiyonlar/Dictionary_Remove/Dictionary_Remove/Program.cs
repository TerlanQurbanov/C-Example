using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Remove
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
            dallar.Remove("İrfan MERGAN");
            foreach (var eleman in dallar)
                Console.WriteLine(eleman);
            Console.ReadLine();
        }
    }
}
