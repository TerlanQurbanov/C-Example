using System;
using System.Text;
using System.Numerics;
namespace BigInteger_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger sayı=3;
            //Console.WriteLine(BigInteger.ModPow(sayı,2,2 ));
            BigInteger bolunen=100;
            BigInteger bolen=3;            
            BigInteger sonuc = 0,kalan=0;
            sonuc = BigInteger.DivRem(bolunen, bolen, out kalan);
            Console.WriteLine("Sonuç = {0}, Kalan = {1}",sonuc,kalan);
            Console.ReadLine();
        }
    }
}
