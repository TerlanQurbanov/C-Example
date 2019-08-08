using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
namespace ListDictionary_AddRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary isimler = new ListDictionary();
            isimler.Add("Volkan AKTAŞ", 1);
            isimler.Add("Bünyamin KARAHAN", 2);
            isimler.Add("İrfan MERGAN", 3);
            isimler.Add("İsmail Hakkı GÜVEN", 4);
            foreach (DictionaryEntry eleman in isimler)
             Console.WriteLine(eleman.Key + " = " + eleman.Value);
            Console.WriteLine("---------------------");
            isimler.Remove("Volkan AKTAŞ");
            foreach (DictionaryEntry eleman in isimler)
                Console.WriteLine(eleman.Key + " = " + eleman.Value);
            Console.ReadLine();

        }
    }
}
