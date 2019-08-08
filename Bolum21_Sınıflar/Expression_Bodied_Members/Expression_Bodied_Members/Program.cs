using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Bodied_Members
{
    class bilgi
    {
        public string isim_bilgisi { get; set; }
        //public string meslek_bilgisi { get; } = "Teknisyen";
        public string meslek_bilgisi => "Teknisyen";
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
