using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {            
            SortedList sınıflar = new SortedList();            
            sınıflar.Add("E10A", "Endüstri Meslek");
            sınıflar.Add("E10B", "Endüstri Meslek");
            sınıflar.Add("T10A", "Teknik Lise");
            sınıflar.Add("A10A", "Anadolu Teknik");
            sınıflar.Add("A10B", "Anadolu Teknik");
            //Console.WriteLine(sınıflar.IndexOfKey("T10A"));
            //Console.WriteLine(sınıflar.IndexOfValue("Teknik Lise"));
            //Console.WriteLine(sınıflar.GetKey(4));
            Console.WriteLine(sınıflar.GetByIndex(4));
            Console.ReadLine();
        }
    }
}
