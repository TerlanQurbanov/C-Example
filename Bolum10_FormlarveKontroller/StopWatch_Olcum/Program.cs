using System;
using System.Diagnostics;
using System.Text;
namespace StopWatch_Olcum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toplam = new int[10000000];
            Random rnd = new Random();
            int rnd_sayi = 0;
            Stopwatch sw = new Stopwatch();            
            sw.Start();            
            for (int i = 0; i < 10000000; i++)
            {
                rnd_sayi=rnd.Next(1,100);
                if (rnd_sayi < 50)
                    toplam[i] = rnd_sayi;
            }            
            sw.Stop();            
            Console.WriteLine("Toplam süre: {0}",sw.Elapsed);
            Console.ReadLine();
        }
    }
}
