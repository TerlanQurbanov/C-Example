using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Count
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
            for (int i = 0; i <= rakamlar.Count - 1; i++)
            {
                Console.WriteLine(rakamlar[i]);
            }
            Console.ReadKey();
        }
    }
}
