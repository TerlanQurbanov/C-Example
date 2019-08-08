using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_parameter
{
    class Meslekler
    {
        private string meslek;
        public Meslekler(string meslek)
        {
            this.meslek = meslek;
        }

        public string Tanim()
        {
            return "Mesleği= " + Meslek;
        }

        public string Meslek
        {
            get { return meslek; }
            set { meslek = value; }
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
