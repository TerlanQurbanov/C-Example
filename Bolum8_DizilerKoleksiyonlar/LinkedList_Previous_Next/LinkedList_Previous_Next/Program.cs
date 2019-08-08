using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Previous_Next
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

            //Baştan sonra doğru listeleme
            LinkedListNode<string> eleman = liste.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }
            //sondan başa doğru listeleme
            //LinkedListNode<string> eleman = liste.Last;
            //while (eleman != null)
            //{
                //Console.WriteLine(eleman.Value);
                //eleman = eleman.Previous;
            //}
            Console.ReadLine();
        }
    }
}
