using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_KeyValuePair
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dallar = new Dictionary<string, string>();
            dallar.Add("Volkan AKTAŞ", "Programlama");
            dallar.Add("Bünyamin KARAHAN", "Programlama");
            dallar.Add("İrfan MERGAN", "Donanım");
            dallar.Add("Hale KATMER", "Web Tasarım");

            foreach (KeyValuePair<string, string> eleman in dallar)           
                Console.WriteLine(eleman.Key + " = " + eleman.Value);          
            Console.ReadLine();
        }
    }
}
