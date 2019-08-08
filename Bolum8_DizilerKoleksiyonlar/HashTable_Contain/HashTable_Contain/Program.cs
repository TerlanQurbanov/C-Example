using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Contain
{
    class Program
    {
        static void Main(string[] args)
        {
            string aranan;
            Hashtable sınıflar = new Hashtable();
            sınıflar.Add("E10A", "Endüstri Meslek");
            sınıflar.Add("E10B", "Endüstri Meslek");
            sınıflar.Add("T10A", "Teknik Lise");
            sınıflar.Add("A10A", "Anadolu Teknik");
            sınıflar.Add("A10B", "Anadolu Teknik");   

            Console.Write("Aranan anahtarı giriniz:");
            aranan = Console.ReadLine();
            //if (sınıflar.ContainsValue(aranan) == false)
            if (sınıflar.ContainsKey(aranan) == false)
            {
                Console.Write("Aranan anahtar bulunamadı");
            }
            else
            {
                Console.Write("Aranan anahtar bulundu");
            }
            Console.ReadKey();
        }
    }
}
