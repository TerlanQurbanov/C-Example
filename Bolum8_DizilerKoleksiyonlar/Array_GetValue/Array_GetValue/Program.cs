using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_GetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Array diller = Array.CreateInstance(typeof(string), 3, 3);
            diller.SetValue("VB.Net", 0, 0);
            diller.SetValue("C#", 0, 1);
            diller.SetValue("C++", 0, 2);
            diller.SetValue("Python", 1, 0);
            diller.SetValue("Perl", 1, 1);
            diller.SetValue("Ruby", 1, 2);
            diller.SetValue("Asp.Net", 2, 0);
            diller.SetValue("JavaScript", 2, 1);
            diller.SetValue("Silverlight", 2, 2);
            //Console.WriteLine(diller.GetValue(0, 1));
            for (int i = 0; i < diller.GetLength(0); i++)
            {
                for (int j = 0; j < diller.GetLength(1); j++)
                {
                    Console.Write(diller.GetValue(i, j) +" ");
                    if (j == diller.GetLength(1) - 1)
                        Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
