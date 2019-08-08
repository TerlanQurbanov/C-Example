using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Add
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

            //Anahtarlar
            ICollection anahtarlar = sınıflar.Keys;
            foreach (string eleman in anahtarlar)
                Console.WriteLine(eleman);
            //Değerler
            //ICollection degerler = sınıflar.Values;            
            //foreach (string eleman in degerler)
            //Console.WriteLine(eleman);
            Console.ReadLine();
        }
    }
}
