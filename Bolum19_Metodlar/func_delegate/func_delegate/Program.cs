using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_delegate
{
    class Program
    {
        public static string Ortalama(int s1, int s2)
        {
            string sonuc = "";
            int ort = (s1 + s2)/2;
            Console.WriteLine("Ortalama=" + ort);
            if (ort >= 50)
                sonuc = "Geçti";
            else
                sonuc = "Kaldı";
            return sonuc;
        }              
        static void Main(string[] args)
        {
            Func<int, int,string> funcSonuc=Ortalama;       
            Console.WriteLine(funcSonuc(80, 80));
            Console.ReadLine();

        }
    }
}
