using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Matching_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            object deger = null;
            Console.WriteLine("Notunuzu Giriniz:");
            deger = Convert.ToInt32(Console.ReadLine());
            switch (deger)
            {
                case int a when a<=0 :
                    Console.WriteLine("0'dan büyük bir değer giriniz!");
                    break;
                case int b when b<50:
                    Console.WriteLine("Kaldınız!");
                    break;
                case int c when c>=50:
                    Console.WriteLine("Geçtiniz!");
                    break;                
            }            
            Console.ReadLine();
        }
    }
}
