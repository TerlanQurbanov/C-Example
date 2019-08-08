using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_ConsoleKeyInfo_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Tuşa Basınız");
            Console.TreatControlCAsInput = true;
            System.ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey();            

            if ((KeyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                Console.Write("ALT+");
            if ((KeyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                Console.Write("SHIFT+");
            if ((KeyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                Console.Write("CTRL+");
            Console.WriteLine(KeyInfo.Key.ToString() + " tuşuna bastınız");
            Console.ReadLine();
        }
    }
}
