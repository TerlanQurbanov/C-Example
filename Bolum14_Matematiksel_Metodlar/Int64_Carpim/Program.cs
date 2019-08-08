using System;
using System.Text;
using System.Numerics;
namespace Int64_Carpim
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sonuc;                        
            sonuc= BigInteger.Multiply(Int32.MaxValue,Int32.MaxValue);
            Console.WriteLine(sonuc);
            Console.ReadLine();        
        }
    }
}
