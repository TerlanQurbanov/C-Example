using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "mehmet", "volkan", "bünyamin", "ömer" };
            var deger = (isimler.Length > 0) ? isimler[0] :
                 throw new Exception("Dizide eleman yok!");
            Console.WriteLine(deger);
            Console.ReadLine();
        }
    }
}
