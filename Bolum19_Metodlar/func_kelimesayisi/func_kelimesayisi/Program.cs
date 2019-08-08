using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_kelimesayisi
{
    class Program
    {
        static void Main(string[] args)
        {          
            Func<string, int, string[]> kelimeler = (s,i) =>
                 i > 0 ? s.Split(' ') : s.Split(' ');
            Console.WriteLine("Bir cümle giriniz=");
            string cumle = Console.ReadLine();           
            foreach (string word in kelimeler(cumle,3))
                Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
