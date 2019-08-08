using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Constructor
{
    class Meslekler(string meslek)
    {
        string _meslek = meslek;       
        public string Tanim()
        {
            return "Mesleği= " + Meslek;
        }

        public string Meslek
        {
            get { return _meslek; }
            set { _meslek = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meslekler m;

            m = new Meslekler("Öğretmen");
            Console.WriteLine(m.Tanim());

            m = new Meslekler("Mühendis");
            Console.WriteLine(m.Tanim());

            Console.ReadLine();
        }
    }
}
