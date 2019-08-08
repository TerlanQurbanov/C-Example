using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_TryGetValue
{
    class Program
    {
        static void Main(string[] args)
        {            
            SortedList<string, string> sınıflar = new SortedList<string, string>();
            sınıflar.Add("E10A", "Endüstri Meslek");
            sınıflar.Add("E10B", "Endüstri Meslek");
            sınıflar.Add("T10A", "Teknik Lise");
            sınıflar.Add("A10A", "Anadolu Teknik");
            sınıflar.Add("A10B", "Anadolu Teknik");
            string deger;
            if (sınıflar.TryGetValue("T10A", out deger))
            {
                Console.WriteLine("T10A anahtarının değeri = " + deger);
            }
            Console.ReadLine();
        }
    }
}
