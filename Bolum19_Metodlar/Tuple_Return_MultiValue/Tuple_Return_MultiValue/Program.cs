using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Return_MultiValue
{
    class Program
    {
        //public static Tuple<int, int> NotTopla(IEnumerable<int> notlar)
        public static (int i, int t) NotTopla(IEnumerable<int> notlar)
        {
            int i = 0, t = 0;
            foreach (var not in notlar)
            {
                i++;
                t += not;
            }
            //return Tuple.Create(i, t);
            return (i, t);
        }
        static void Main(string[] args)
        {
            var notlar = new[] { 90, 60, 80, 70 };
            var nothesapla = NotTopla(notlar);
            //Console.WriteLine("Ortalama=" + (nothesapla.Item2 / nothesapla.Item1));
            Console.WriteLine("Ortalama=" + (nothesapla.t / nothesapla.i));
            Console.ReadLine();
        }

    }
}
