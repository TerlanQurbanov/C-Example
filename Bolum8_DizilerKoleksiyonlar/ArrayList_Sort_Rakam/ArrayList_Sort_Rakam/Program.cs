using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Sort_Rakam
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(8);
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(9);
            rakamlar.Add(7);
            rakamlar.Sort();
            Console.WriteLine(rakamlar[0]);
            Console.WriteLine(rakamlar[1]);
            Console.WriteLine(rakamlar[2]);
            Console.WriteLine(rakamlar[3]);
            Console.WriteLine(rakamlar[4]);
            Console.ReadKey();
        }
    }
}
