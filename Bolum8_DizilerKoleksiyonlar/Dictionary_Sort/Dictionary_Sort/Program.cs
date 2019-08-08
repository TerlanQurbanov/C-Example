using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bilgi = new Dictionary<string, int>()
            {
                {"Talha AKTAŞ", 12},
                {"Sümeyye AKTAŞ", 9},
                {"Murat AKTAŞ" , 19},
                {"Azra UNCU", 6}
            };
            List<string> lst_bilgi = new List<string>(bilgi.Keys); 
            lst_bilgi.Sort();
            foreach (string anahtar in lst_bilgi)
                Console.WriteLine(anahtar);
            Console.ReadLine();
        }
    }
}
