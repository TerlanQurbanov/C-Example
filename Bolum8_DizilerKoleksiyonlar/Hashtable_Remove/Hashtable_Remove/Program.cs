using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable sınıflar = new Hashtable();
            sınıflar.Add("E10A", "Endüstri Meslek");
            sınıflar.Add("E10B", "Endüstri Meslek");
            sınıflar.Add("T10A", "Teknik Lise");
            sınıflar.Add("A10A", "Anadolu Teknik");
            sınıflar.Add("A10B", "Anadolu Teknik");            
                       
            foreach (DictionaryEntry eleman in sınıflar)
                Console.WriteLine(eleman.Key + " = " + eleman.Value);

            sınıflar.Remove("A10B");            
            Console.WriteLine("-------------------------");
            foreach (DictionaryEntry eleman in sınıflar)
                Console.WriteLine(eleman.Key + " = " + eleman.Value);
            Console.ReadLine();
        }
    }
}
