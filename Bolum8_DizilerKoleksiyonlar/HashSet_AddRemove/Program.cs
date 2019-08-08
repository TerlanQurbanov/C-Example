using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_AddRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> okul = new HashSet<string>();
            okul.Add("Teknik");
            okul.Add("Anadolu Teknik");
            okul.Add("Endüstri Meslek");
            okul.Add("Anadolu Meslek");
            foreach (string degerler in okul)
                Console.WriteLine(degerler);
            Console.WriteLine("---------------------");
            okul.Remove("Anadolu Meslek");
            foreach (string degerler in okul)
                Console.WriteLine(degerler);
            Console.ReadLine();

        }
    }
}
