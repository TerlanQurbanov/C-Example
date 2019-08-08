using System;
using System.Collections.Specialized;
using System.Text;
namespace Ordered_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary od = new OrderedDictionary();
            od.Add("T10A","Teknik");
            od.Add("A10A","Anadolu Teknik");
            od.Add("E10A","Endüstri Meslek");
            od.Insert(0,"M10A","Anadolu Meslek");
           
            string[] anahtarlar = new string[od.Keys.Count];
            od.Keys.CopyTo(anahtarlar, 0);
            for (int i = 0; i < od.Keys.Count; i++)
            {
                Console.WriteLine(
                    "İndex = {0}, Anahtar = {1}, Değer = {2}",
                    i,anahtarlar[i],od[i]);
            } 
            Console.ReadLine();
        }
    }
}
