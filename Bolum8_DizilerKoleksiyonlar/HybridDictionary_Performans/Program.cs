using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
namespace HybridDictionary_Performans
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangiczamani, bitiszamani;
            TimeSpan fark;            
            int[] dizi = new int[1000000];
            Random rs = new Random();                     
           
            for (int i = 0; i < 999999; i++)            
                dizi[i]=rs.Next(0,100000);            
                                   
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
