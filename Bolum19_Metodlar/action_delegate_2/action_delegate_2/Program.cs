using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action_delegate_2
{
    class Program
    {
        public static void Topla(int s1, int s2)
        {
            Console.WriteLine("Toplam=" + (s1 + s2));
        }
        public static void Cikar(int s1, int s2)
        {
            Console.WriteLine("Fark=" + (s1 - s2));
        }
        public static Action<int, int> actionSonuc;
        static void Main(string[] args)
        {
            Console.WriteLine("Operatörü giriniz");
            string opt = Console.ReadLine();
            if (opt == "+")
                actionSonuc = delegate (int sayi1, int sayi2) { Topla(sayi1, sayi2); };
            else if (opt == "-")
                actionSonuc = delegate (int sayi1, int sayi2) { Cikar(sayi1, sayi2); };
            actionSonuc(5, 3);
            Console.ReadLine();
        }
    }
}
