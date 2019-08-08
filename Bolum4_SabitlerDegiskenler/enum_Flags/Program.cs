using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Flags
{
    class Program
    {
        //Hatalı
        //[Flags()]
        //enum uzmanlık
        //{
            //VBNet = 1,
            //PHP = 2,
            //ASPNet = 3,
            //CSharp = 4
        //}
        //Doğru
        [Flags()]
        enum uzmanlık
        {
            VBNet = 1,
            PHP = 2,
            ASPNet = 4,
            CSharp = 8
        }

        static void Main(string[] args)
        {
            uzmanlık masaustuprogramlama = uzmanlık.
                VBNet | uzmanlık.CSharp;
            uzmanlık webprogramlama = uzmanlık.PHP | uzmanlık.ASPNet;
            Console.WriteLine("Masaüstü Programlama");
            Console.WriteLine(masaustuprogramlama.ToString());
            Console.WriteLine(masaustuprogramlama.ToString("G"));
            Console.WriteLine(masaustuprogramlama.ToString("d"));
            Console.WriteLine(masaustuprogramlama.ToString("F"));
            Console.WriteLine(masaustuprogramlama.ToString("X"));
            Console.WriteLine("----------------------");
            Console.WriteLine("Web Programlama");
            Console.WriteLine(webprogramlama.ToString());
            Console.WriteLine(webprogramlama.ToString("G"));
            Console.WriteLine(webprogramlama.ToString("d"));
            Console.WriteLine(webprogramlama.ToString("F"));
            Console.WriteLine(webprogramlama.ToString("X"));
            Console.ReadLine();

        }
    }
}
