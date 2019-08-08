using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_YasHesap
{
    class Program
    {
        //public static readonly int yil = 2014;
        public static readonly int yil = DateTime.Now.Year;
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum yılınızı giriniz");
            int dogum_yili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yaşınız= " + (yil - dogum_yili));
            Console.ReadKey();
        }
    }
}
