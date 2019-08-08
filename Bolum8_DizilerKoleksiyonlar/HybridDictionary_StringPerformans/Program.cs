using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridDictionary_StringPerformans
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strChars = {"A","B","C","D","E","F","G","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z"};
            DateTime baslangiczamani, bitiszamani;
            TimeSpan fark;
            string[] dizi = new string[1000000];
            Random rnd = new Random();
            
            int mb = strChars.GetUpperBound(0);
            for (int i = 0; i <999999; i++)              
                dizi[i]=strChars[rnd.Next(mb)];            
            
            HybridDictionary hl = new HybridDictionary();
            baslangiczamani = DateTime.Now;
            for (int i = 0; i <= 999999; i++)            
                hl.Add(i, dizi[i]);            
            bitiszamani = DateTime.Now;
            fark = bitiszamani - baslangiczamani;
            Console.WriteLine("HybridDictionary işlem zamanı (ms) = " + fark.Milliseconds);

            Hashtable ht = new Hashtable();
            baslangiczamani = DateTime.Now;
            for (int i = 0; i < 999999; i++)            
                ht.Add(i, dizi[i]);           
            bitiszamani = DateTime.Now;
            fark = bitiszamani - baslangiczamani;
            Console.WriteLine("Hashtable işlem zamanı (ms) = " + fark.Milliseconds);
            Console.ReadLine();
        }
    }
}
