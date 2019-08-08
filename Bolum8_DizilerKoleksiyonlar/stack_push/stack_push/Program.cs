using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_push
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
            foreach (string i in isimler)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
