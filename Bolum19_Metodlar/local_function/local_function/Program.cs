using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_function
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Cift_LocalFunction(int sayi)
            {
                bool sonuc = false;
                if (sayi % 2 == 0)
                    sonuc = true;
                else
                    sonuc = false;
                return sonuc;                
            }            
            Console.WriteLine("Bir Sayý Giriniz");
            int okunandeger = Convert.ToInt32(Console.ReadLine());
            if (Cift_LocalFunction(okunandeger))
                Console.WriteLine("Sayý çift");
            else
                Console.WriteLine("Sayý tek");
            Console.ReadKey();
        }
    }
}
