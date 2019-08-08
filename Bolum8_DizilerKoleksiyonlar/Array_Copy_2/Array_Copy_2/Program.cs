using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Copy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diller = new string[5];
            diller[0] = "VB.Net";
            diller[1] = "C#";
            diller[2] = "ASP.Net";
            string[] digerdiller = new string[3];
            digerdiller[0] = "Python";
            digerdiller[1] = "F#";
            digerdiller[2] = "C++";            
            Array.Copy(digerdiller, 1, diller, 3, 2);
            Console.WriteLine(diller[0]);
            Console.WriteLine(diller[1]);
            Console.WriteLine(diller[2]);
            Console.WriteLine(diller[3]);
            Console.WriteLine(diller[4]);
            Console.ReadLine();
        }
    }
}
