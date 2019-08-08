using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
namespace ListDictionary_Performans
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangiczamani,bitiszamani;
            TimeSpan fark;
           
            ListDictionary isimler_list = new ListDictionary();
            isimler_list.Add("Volkan AKTAŞ", 1);
            isimler_list.Add("Bünyamin KARAHAN", 2);
            isimler_list.Add("İrfan MERGAN", 3);
            isimler_list.Add("İsmail Hakkı GÜVEN", 4);
            isimler_list.Add("Murat UNCU", 5);

            Hashtable isimler_hash = new Hashtable();
            isimler_hash.Add("Volkan AKTAŞ", 1);
            isimler_hash.Add("Bünyamin KARAHAN", 2);
            isimler_hash.Add("İrfan MERGAN", 3);
            isimler_hash.Add("İsmail Hakkı GÜVEN", 4);
            isimler_hash.Add("Murat UNCU", 5);
            baslangiczamani = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                object a = isimler_list["Volkan AKTAŞ"];
            }
            bitiszamani = DateTime.Now;
            fark = bitiszamani-baslangiczamani;
            Console.WriteLine("ListDictionary işlem zamanı (ms) = " + fark.Milliseconds);

            baslangiczamani = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                object a = isimler_hash["Volkan AKTAŞ"];
            }
            bitiszamani = DateTime.Now;
            fark = bitiszamani - baslangiczamani;
            Console.WriteLine("Hashtable işlem zamanı (ms) = " + fark.Milliseconds);
            Console.ReadLine();
        }
    }
}
