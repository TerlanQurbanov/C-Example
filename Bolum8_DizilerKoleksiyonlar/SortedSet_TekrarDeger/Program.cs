using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_TekrarDeger
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> okul = new SortedSet<string>();
            okul.Add("Teknik");
            okul.Add("Anadolu Teknik");
            okul.Add("Endüstri Meslek");
            //okul.Add("Anadolu Meslek");
            //bool donen_deger=okul.Add("Teknik");
            foreach (string degerler in okul)
                Console.WriteLine(degerler);
            //Console.WriteLine(donen_deger);
            Console.ReadLine();
        }
    }
}
