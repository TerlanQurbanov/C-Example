using System;
using System.Collections.Specialized;
using System.Text;
namespace StringCollection_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection diller = new StringCollection();
            diller.Add("F#");
            diller.Add("VB.Net");
            diller.Insert(0,"C#");
            string[] scriptdiller = new string[]{"Perl", "Ruby", "Python"}; 
            diller.AddRange(scriptdiller);
            foreach (string isim in diller)
                Console.WriteLine(isim);
            Console.ReadLine();
        }
    }
}
