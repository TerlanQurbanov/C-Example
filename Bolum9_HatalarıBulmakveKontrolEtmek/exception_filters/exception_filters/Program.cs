using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace exception_filters
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
                    Console.WriteLine("Kaldýnýz");
                else if (notu >= 45 & notu <= 100)
                    Console.WriteLine("Geçtiniz");
                else if (notu > 100 & notu <= 255)
                    throw new OverflowException();
            }
            catch (Exception ex) if (ex is OverflowException)
            {                 
                ex.Data["stringInfo"] = "100'den büyük bir deðer girdiniz";
                ex.Data["Time"] = DateTime.Now;
              
                foreach (DictionaryEntry bilgi in ex.Data)
                    Console.WriteLine(bilgi.Value.ToString());
            }
            Console.ReadLine();
        }
    }
}
