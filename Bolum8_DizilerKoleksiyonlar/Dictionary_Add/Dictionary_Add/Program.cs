using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Add
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
           
           //Console.WriteLine(dallar["Bünyamin KARAHAN"]);            
            foreach (var eleman in dallar)
                Console.WriteLine(eleman);           
            Console.ReadLine();
        }
    }
}
