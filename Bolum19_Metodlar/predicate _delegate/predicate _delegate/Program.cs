using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predicate__delegate
{
    class Program
    {
        public static bool Cift(int sayi)
        {           
            return (sayi%2==0);
        }
        static void Main(string[] args)
        {                        
            Predicate<int> predicateSonuc=Cift;
            Console.WriteLine(predicateSonuc(4));
            Console.ReadLine();
        }
    }
}
