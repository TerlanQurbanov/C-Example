using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_RemoveWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> okul = new SortedSet<string>();
            okul.Add("Teknik");
            okul.Add("Anadolu Teknik");
            okul.Add("Endüstri Meslek");
            okul.Add("Anadolu Meslek");
            foreach (string degerler in okul)
                Console.WriteLine(degerler);
            Console.WriteLine("---------------------");
            okul.RemoveWhere(deger => deger.StartsWith("A"));
            foreach (string degerler in okul)
                Console.WriteLine(degerler);
            Console.ReadLine();

        }
    }
}
