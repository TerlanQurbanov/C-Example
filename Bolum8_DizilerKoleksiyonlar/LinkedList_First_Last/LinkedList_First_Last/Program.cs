using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_First_Last
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
            Console.WriteLine("Listenin ilk elemanı= " + liste.First.Value);
            Console.WriteLine("Listenin son elemanı= " + liste.Last.Value);
            Console.ReadLine();
        }
    }
}
