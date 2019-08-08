using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_Sifre
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyInfo = default(ConsoleKeyInfo);
            string password = "";
            do
            {
                KeyInfo = Console.ReadKey(true);

                if (KeyInfo.Key != ConsoleKey.Backspace)
                {
                    password += KeyInfo.KeyChar;
                    Console.Write("*");
                }
            } while (!(KeyInfo.Key == ConsoleKey.Enter));

            Console.WriteLine();
            Console.WriteLine("Girilen Şifre : " + password);
            Console.ReadLine();

        }
    }
}
