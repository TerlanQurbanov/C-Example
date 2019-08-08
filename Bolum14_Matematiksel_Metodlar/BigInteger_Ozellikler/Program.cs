using System;
using System.Text;
using System.Numerics;
namespace BigInteger_Ozellikler
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sayı;
            sayı = BigInteger.Parse("1267650600228229401496703205376");
            Console.WriteLine("Sayı 2'nin katı mı? = " + sayı.IsPowerOfTwo);
            Console.ReadLine();
        }
    }
}
