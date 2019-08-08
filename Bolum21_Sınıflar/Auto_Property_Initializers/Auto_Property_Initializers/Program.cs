using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Property_Initializers
{
    class bilgi
    {
        public string isim_bilgisi { get; set; }
        public string meslek_bilgisi { get;} = "Teknisyen";
    }
    class Program
    {
        static void Main(string[] args)
        {
            bilgi bilgiler = new bilgi();
            bilgiler.isim_bilgisi = "Enver ARSLAN";
            Console.WriteLine(bilgiler.isim_bilgisi.ToString());
            Console.WriteLine(bilgiler.meslek_bilgisi.ToString());
            Console.ReadLine();
        }
    }
}
