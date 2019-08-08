using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hybrid_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {            
            HybridDictionary hl= new HybridDictionary();          
            hl.Add("C#", 1);
            //hl["Asp.NET"] = 0;
            hl.Add("Vb.Net", 2);
            hl.Add("Visual C++", 3);                                   
            foreach (DictionaryEntry anahtarlar in hl)
                Console.WriteLine(anahtarlar.Key + " = " + anahtarlar.Value);        
            Console.ReadLine();
        }
    }
}
