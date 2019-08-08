using System;
using System.Text;
using System.Threading;
namespace timer_Console_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback tmrCb = new TimerCallback(Saat);
            Timer tmr = new Timer(tmrCb, null, 0, 1000);                      
            Console.ReadLine();
            tmr.Dispose();
        }
        private static void Saat(Object state)
        {
            Console.Clear();
            Console.Write(string.Format("{0:hh:mm:ss}", DateTime.Now));           
        } 

    }
}
