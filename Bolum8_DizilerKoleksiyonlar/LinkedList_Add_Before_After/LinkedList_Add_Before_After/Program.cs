using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Add_Before_After
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> liste = new LinkedList<string>();
            liste.AddLast("Değer 2");
            liste.AddLast("Değer 3");
            liste.AddLast("Değer 4");
            liste.AddFirst("Değer 1");

            //liste.AddBefore(liste.Find("Değer 3"), "Eklenen Değer");
            liste.AddAfter(liste.Find("Değer 3"), "Eklenen Değer");
            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadLine();
        }
    }
}
