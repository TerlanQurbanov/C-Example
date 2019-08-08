using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_pop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> isimler = new Stack<string>();
            isimler.Push("Talha");
            isimler.Push("Sümeyye");
            isimler.Push("Azra");
            isimler.Push("Murat");

            Console.WriteLine("En üstte yer alan eleman= " +isimler.Peek());
            isimler.Pop();
            Console.WriteLine("En üstte yer alan eleman= " + isimler.Peek());
            Console.ReadLine();         
        }
    }
}
