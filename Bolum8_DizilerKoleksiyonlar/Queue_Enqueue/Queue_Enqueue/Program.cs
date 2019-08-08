using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Enqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> isimler = new Queue<string>();
            isimler.Enqueue("Talha");
            isimler.Enqueue("Sümeyye");
            isimler.Enqueue("Azra");
            isimler.Enqueue("Murat");
            Console.WriteLine("En üstte yer alan eleman= " +isimler.Peek());
            isimler.Dequeue();
            Console.WriteLine("En üstte yer alan eleman= " +isimler.Peek());
            Console.ReadLine();                
        }
    }
}
