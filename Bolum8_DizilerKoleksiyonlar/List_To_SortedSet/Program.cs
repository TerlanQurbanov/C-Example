using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_To_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Teknik");
            list.Add("Anadolu Teknik");
            list.Add("Endüstri Meslek");
            list.Add("Anadolu Meslek");
            list.Add("Teknik");
            SortedSet<string> s_set = new SortedSet<string>(list);           
            foreach (string degerler in s_set)           
                Console.WriteLine(degerler);
            Console.ReadLine();
        }
    }
}
