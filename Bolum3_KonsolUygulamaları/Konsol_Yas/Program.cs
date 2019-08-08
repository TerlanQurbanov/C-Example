using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_Yas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum Yılınızı Girin");
            //int yil = Console.Read();
            int yil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yaşınız " + DateTime.Now.Year + "-" + yil +
                "=" + (DateTime.Now.Year - yil));
            Console.ReadKey();
        }
    }
}
