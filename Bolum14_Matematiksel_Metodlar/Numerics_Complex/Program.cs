using System;
using System.Text;
using System.Numerics;
namespace Numerics_Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(1, 2);
            Console.WriteLine("Karmaşık sayının real kısmı :" + c.Real.ToString());
            Console.WriteLine("Karmaşık sayının imaginary kısmı :" + c.Imaginary.ToString());
            Console.WriteLine("Exp({0}) = {1}",c, Complex.Exp(c));
            Console.WriteLine("Cos({0}) = {1}", c, Complex.Cos(c));
            Console.ReadLine();
        }
    }
}
