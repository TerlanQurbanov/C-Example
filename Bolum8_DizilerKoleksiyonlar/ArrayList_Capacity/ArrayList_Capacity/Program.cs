using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Capacity
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            Console.WriteLine("Eleman Sayısı= " + rakamlar.Count);
            Console.WriteLine("Kapasite= " + rakamlar.Capacity);
            rakamlar.Remove(5);
            rakamlar.Remove(4);
            Console.WriteLine("Yeni Eleman Sayısı= " + rakamlar.Count);
            Console.WriteLine("Yeni Kapasite= " + rakamlar.Capacity);
            Console.ReadKey();
        }
    }
}
