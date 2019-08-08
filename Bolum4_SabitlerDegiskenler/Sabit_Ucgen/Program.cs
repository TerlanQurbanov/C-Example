using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabit_Ucgen
{
    class Program
    {
        static void Main(string[] args)
        {
            // PI değerini sabit olarak tanımladık
            const double PI = 3.142857143;
            //değişkenler
            Double alan,çevre,yarıçap;
            
            Console.Write("Yarıçapı giriniz = ");          
            yarıçap = Convert.ToInt32(Console.ReadLine());

            çevre = 2 * PI * yarıçap;
            alan = PI * (Math.Pow(yarıçap, 2));
          
            Console.WriteLine("Dairenin çevresi (cm) = " + çevre );
            Console.WriteLine("Dairenin alanı (cm) = " + alan);
            Console.ReadLine();
        }
    }
}
