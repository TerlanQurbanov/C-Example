using System;
using System.Text;
using System.Timers;
namespace timer_console
{
    class Program
    {
        static void Main(string[] args)
        {            
            Timer tmr = new Timer();
            tmr.Elapsed += tmr_Elapsed;
            tmr.Interval = 1000;
            tmr.Start();
            Console.ReadLine();
        }
        static void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.Write(string.Format("{0:hh:mm:ss}", DateTime.Now));
        }
    }
}
