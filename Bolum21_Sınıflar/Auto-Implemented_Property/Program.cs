using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented_Property
{
    class bilgi
    {        
        public string isim_bilgisi { get; set; }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            bilgi ad = new bilgi();
            ad.isim_bilgisi = "Volkan AKTAŞ";
            Console.WriteLine(ad.isim_bilgisi.ToString());
            Console.ReadLine();
        }
    }
}
