using System;
using System.Text;
namespace StringBuilder_Performans
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string yazi = "";
            DateTime baslangiczamani;
            DateTime bitiszamani;
            baslangiczamani = DateTime.Now;
            for (i = 0; i <= 100000; i++)            
                yazi = yazi + i.ToString();            
            bitiszamani = DateTime.Now;
            Console.WriteLine("String Sınıfı Başlangıç Zamanı= " +
                                baslangiczamani.ToString());
            Console.WriteLine("String Sınıfı Bitiş Zamanı= " +
                                bitiszamani.ToString());
            Console.WriteLine();

            StringBuilder sb = new StringBuilder();
            baslangiczamani = DateTime.Now;
            for (i = 0; i <= 100000; i++)            
                sb.Append(i.ToString());            
            bitiszamani = DateTime.Now;
            Console.WriteLine("StringBuilder Sınıfı Başlangıç Zamanı= " +
                                baslangiczamani.ToString());
            Console.WriteLine("StringBuilder Sınıfı Bitiş Zamanı= " +
                                bitiszamani.ToString());
            Console.ReadKey();
        }
    }
}
