using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_birdenfazlaexception
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger, sonuc, bolen;
            try
            {
                Console.Write("Sayıyı Giriniz:");
                deger = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bölen Sayıyı Giriniz:");
                bolen = Convert.ToInt32(Console.ReadLine());
                sonuc = deger / bolen;
            }
            // Sıfıra Bölme Hatası
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra Bölme Hatası");
                sonuc = int.MaxValue;
            }
            // Arithmetik Hata            
            catch (ArithmeticException)
            {
                Console.WriteLine("Aritmetik Hata");
                sonuc = int.MaxValue;
            }
            // Tanımlanmamış Hata 
            catch
            {
                Console.WriteLine("Tanımlanmamış Hata");
                sonuc = int.MaxValue;
            }
            Console.WriteLine("Sonuç = {0}", sonuc);
            Console.ReadKey();
        }
    }
}
