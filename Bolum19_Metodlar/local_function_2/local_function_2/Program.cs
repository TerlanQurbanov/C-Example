using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_function_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Cift_LocalFunction(int sayi) =>(sayi % 2 == 0);           
            Console.WriteLine("Bir Say� Giriniz");
            int okunandeger = Convert.ToInt32(Console.ReadLine());
            if (Cift_LocalFunction(okunandeger))
                Console.WriteLine("Say� �ift");
            else
                Console.WriteLine("Say� tek");
            Console.ReadKey();
        }
    }
}
