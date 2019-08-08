using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Degisken_2
{
    class Program
    {
        public static int b;
        static void Main(string[] args)
        {
            int a = 10;
            {
                b = 20;      
            }
            Console.WriteLine(a + b);
            Console.ReadLine(); 
        }        
    }
}
