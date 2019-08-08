using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj;
            object boxing;

            mesaj = "İlk mesajımız";

            boxing = mesaj;

            Console.WriteLine(mesaj);
            Console.WriteLine(boxing);

            mesaj = "Yeni Mesajımız";

            Console.WriteLine(mesaj);
            Console.WriteLine(boxing);

            Console.ReadLine();
        }
    }
}
