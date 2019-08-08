using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = null;
            object boxing = null;

            mesaj = "İlk mesajımız";

            boxing = mesaj;

            Console.WriteLine(mesaj);
            Console.WriteLine(boxing);

            mesaj = "Yeni Mesajımız";

            Console.WriteLine(mesaj);
            Console.WriteLine(boxing);

            string digermesaj = (string)boxing;

            Console.WriteLine(digermesaj);

            Console.ReadLine();
        }
    }
}
