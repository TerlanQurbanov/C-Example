using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_if_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {             
                Console.WriteLine("Notu Girin");
                byte notu = Convert.ToByte(Console.ReadLine());
                if (notu < 45)
                    Console.WriteLine("Kaldınız");
                else if (notu >= 45 & notu <= 100)
                    Console.WriteLine("Geçtiniz");
                else if (notu > 100 & notu <= 255)
                    throw new OverflowException();
            }
            catch (Exception ex)
            {
                if (ex is OverflowException)
                {
                    ex.Data["stringInfo"] = "100'den büyük bir değer girdiniz";
                    ex.Data["Time"] = DateTime.Now;
                }
                foreach (DictionaryEntry bilgi in ex.Data)
                    Console.WriteLine(bilgi.Value.ToString());
            }
            Console.ReadLine();
        }
    }
}
