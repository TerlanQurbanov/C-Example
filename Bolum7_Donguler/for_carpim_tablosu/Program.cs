using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_carpim_tablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sutun=1; 
            int satir=0;
            for (int i=1; i<=10;i++)
            {
                for (int j=1;j<=10;j++)
                {
                   Console.SetCursorPosition(sutun,satir+j);
                    Console.Write(i +"x" + j +'=' + (i*j));
                }
                sutun=sutun+14;   
                if (i==5)
                {
                    sutun=1;
                    satir=13;
                }
            }            
            Console.ReadLine();
        }
    }
}
