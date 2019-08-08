using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabit2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double urunfiyatı = 100;
            const double kdvlifiyat = urunfiyatı + (urunfiyatı * 0.18);
            byte adet = 0;
            Console.Write("Ürün adedini giriniz: ");
            adet = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Toplam Fiyat= " + kdvlifiyat * adet);
            Console.ReadKey();

        }
    }
}
