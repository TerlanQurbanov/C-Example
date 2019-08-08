using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_x_o
{
    class Program
    {
        static void Main(string[] args)
        {
            string m, a;
            int i;
            Console.WriteLine("mesajınızı girin:");
            m = Console.ReadLine();
            Console.WriteLine(" x veya o şeklinde yaz:");
            a = Console.ReadLine();
            if (a == "x")
            {
                for (i = 1; i <= 20; i++)
                {
                    Console.SetCursorPosition(i + 30, i);
                    Console.Write(m);
                    Console.SetCursorPosition(50 - i, i);
                    Console.Write(m);
                }
            }
            else if (a == "o")
            {
                for (i = 12; i > 1; i--)
                {
                    Console.SetCursorPosition(34 - i, i);
                    Console.Write(m);
                    Console.SetCursorPosition(39 + i, i);
                    Console.Write(m);
                    Console.SetCursorPosition(21 + i, i + 12);
                    Console.Write(m);
                    Console.SetCursorPosition(52 - i, i + 12);
                    Console.Write(m);
                    
                }
            }
            Console.ReadLine();
        }
    }
}
