using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_SetCursorPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 15);
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("C Sharp");
            Console.ReadLine();
        }
    }
}
