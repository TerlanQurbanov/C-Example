using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Add_Find
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
            
            LinkedListNode<string> bulunan = liste.Find("Değer 3");
            Console.WriteLine(" Bulunan değer= " +bulunan.Value.ToString());
            Console.WriteLine(" Bulunan değerin sonrası= " + bulunan.Next.Value.ToString());
            Console.WriteLine(" Bulunan değerin öncesi= " + bulunan.Previous.Value.ToString());
            Console.ReadLine();

        }
    }
}
