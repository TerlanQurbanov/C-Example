using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_isimdizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adsoyad = { "Volkan AKTAŞ", "Ayşe AKTAŞ", 
                         "Talha Osman AKTAŞ", "Sümeyye AKTAŞ" };

            foreach (string eleman in adsoyad)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
        }
    }
}
