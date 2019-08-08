using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
namespace OrderedDictionary_Remove_RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary od = new OrderedDictionary();
            od.Add("T10A", "Teknik");
            od.Add("A10A", "Anadolu Teknik");
            od.Add("E10A", "Endüstri Meslek");
            od.Insert(0, "M10A", "Anadolu Meslek");
            od.Remove("E10A");
            od.RemoveAt(0);

            IDictionaryEnumerator eleman = od.GetEnumerator();
            while (eleman.MoveNext())
            {
                Console.WriteLine("Anahtar = {0}, Değer = {1}",
                eleman.Key,eleman.Value);            
            }
            Console.ReadLine();
        }
    }
}
