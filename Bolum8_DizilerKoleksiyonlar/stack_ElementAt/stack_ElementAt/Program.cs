using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_ElementAt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Stack<string> isimler = new Stack<string>();
            isimler.Push("Talha");
            isimler.Push("Sümeyye");
            isimler.Push("Azra");
            isimler.Push("Murat");            
            for (i = 0; i<isimler.Count ; i++)
                Console.WriteLine(isimler.ElementAt(i));
            Console.ReadLine();
        }
    }
}
