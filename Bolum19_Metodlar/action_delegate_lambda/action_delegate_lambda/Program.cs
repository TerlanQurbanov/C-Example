using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action_delegate_lambda
{
    class Program
    {       
        public static Action<int, int> actionSonuc;
        static void Main(string[] args)
        {            
            Console.WriteLine("Operatörü giriniz");
            string opt = Console.ReadLine();
            if (opt == "+")
                actionSonuc = (sayi1, sayi2) => Console.WriteLine(sayi1 + sayi2);
            else if (opt == "-")
                actionSonuc = (sayi1, sayi2) => Console.WriteLine(sayi1 - sayi2);
            actionSonuc(5, 3);
            Console.ReadLine();
        }
    }
}
