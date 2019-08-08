using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_property_ucgen
{
    class Program
    {
        struct ucgen
        {
            private int r;
            public int yaricap
            {
                get
                {
                    return r;
                }
                set
                {
                    r = value;
                }
            }
        }
        static void Main(string[] args)
        {
            ucgen ucgen1 = new ucgen();
            Console.WriteLine("Üçgenin yarı çapını giriniz=");
            ucgen1.yaricap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin çevresi= " + (2 * 3.14 * ucgen1.yaricap));
            Console.ReadLine();
        }
    }
}
