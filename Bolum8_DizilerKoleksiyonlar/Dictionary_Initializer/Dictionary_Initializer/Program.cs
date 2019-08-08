using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Dictionary_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bilgi = new Dictionary<string, int>()
            {
                ["Talha"] = 12,
                ["Sümeyye"] = 9,
                ["Murat"] = 19,
                ["Mehmet"] = 21
            };
            Console.WriteLine(bilgi["Talha AKTAÞ"]);
            Console.ReadLine();
        }
    }
}
