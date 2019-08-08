using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_return
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diller = { "C++", "C#", "Python" , "Java"};
            ref string dil = ref StringYaz(3, diller);
            dil = "Go";
            Console.WriteLine(diller[3]);
            Console.ReadKey();
        }
        public static ref string StringYaz(int indeks, string[] degerler)
        {
            foreach (string deger in degerler)
            {
                if (degerler[indeks] == deger)
                    return ref degerler[indeks];
            }
            throw new Exception("Aranan değer bulunamadı");
        }
    }
}
