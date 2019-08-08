using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_or
{
    class Program
    {
        enum uzmanlık
        {
            VBNet = 1,
            CSharp = 2,
            ASPNet = 4,
            PHP = 8,
            Python = 10,
            Perl = 20,
            ButunDiller = (VBNet | CSharp | ASPNet | PHP | Python | Perl)
        }
        //[Flags()]
        //enum uzmanlık
        //{
            //VBNet = 1,
            //CSharp = 2,
            //ASPNet = 4,
            //PHP = 8,
            //Python = 10,
            //Perl = 20
        //}

        static void Main(string[] args)
        {
            uzmanlık webprogramlama = uzmanlık.ASPNet | uzmanlık.PHP;
            Console.WriteLine(webprogramlama.ToString());
            Console.WriteLine(webprogramlama.ToString("G"));
            Console.WriteLine(webprogramlama.ToString("d"));
            Console.WriteLine(webprogramlama.ToString("F"));
            Console.WriteLine(webprogramlama.ToString("X"));
            Console.ReadLine();
        }
    }
}
