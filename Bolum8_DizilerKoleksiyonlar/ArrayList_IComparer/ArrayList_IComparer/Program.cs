using System;
using System.Collections;
using System.Text;
namespace ArrayList_IComparer
{
    public class Compare : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            return ((new  CaseInsensitiveComparer()).Compare(y, x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Compare CompareOptions = new Compare();
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(8);
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(9);
            rakamlar.Add(7);
            rakamlar.Sort(CompareOptions);
            Console.WriteLine(rakamlar[0]);
            Console.WriteLine(rakamlar[1]);
            Console.WriteLine(rakamlar[2]);
            Console.WriteLine(rakamlar[3]);
            Console.WriteLine(rakamlar[4]);
            Console.ReadKey();
        }
    }
}
