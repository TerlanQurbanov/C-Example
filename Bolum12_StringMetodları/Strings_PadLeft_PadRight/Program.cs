using System;
using System.Text;
namespace Strings_PadLeft_PadRight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Deneme".PadRight(10));
            //Console.WriteLine("Deneme".PadLeft(20, '-'));
            Console.Write("Adınız".PadRight(15, '.'));
            Console.WriteLine("Volkan");

            Console.Write("Soyadınız".PadRight(15, '.'));
            Console.WriteLine("Aktaş");
            Console.ReadLine();            
        }
    }
}
