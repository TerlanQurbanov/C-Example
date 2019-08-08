using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Program nsn_tarih = new Program();
            Console.ReadLine();
        }

        readonly DateTime tarih;
        public Program()
        {
            tarih = DateTime.Now;
            Console.WriteLine(tarih);
        }
    }
}
