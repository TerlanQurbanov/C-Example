using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_MantıksalOperator
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
            Perl = 20
        }
        static void Main(string[] args)
        {
            uzmanlık masaustuprogramlama = uzmanlık.
                VBNet | uzmanlık.CSharp;
            Console.WriteLine(masaustuprogramlama.ToString());
            Console.WriteLine(masaustuprogramlama.ToString("G"));
            Console.WriteLine(masaustuprogramlama.ToString("d"));
            Console.WriteLine(masaustuprogramlama.ToString("F"));
            Console.WriteLine(masaustuprogramlama.ToString("X"));
            Console.ReadLine();

        }
    }
}
