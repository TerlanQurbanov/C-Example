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

namespace params_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(NotHesapla(45,new int[] { 80, 90, 100 }));
            Console.ReadLine();
        }      
        public static int NotHesapla(int yazýlý,params IEnumerable<int>[] sozlu)
        {
            byte puan = 0;
            int i,notu = 0,sozlusayisi=0;            
            var sozlutoplam = 0;                        
                          
            sozlusayisi = sozlu[0].Count();
            for (i=0;i<sozlusayisi;i++)
                sozlutoplam += sozlu[0].ElementAt(i);                      

            if (sozlusayisi > 0)
                notu = (yazýlý + sozlutoplam) / (sozlusayisi+1);

            if (notu < 25)
                puan = 0;
            else if (notu < 45)
                puan = 1;
            else if (notu < 55)
                puan = 2;
            else if (notu < 70)
                puan = 3;
            else if (notu < 85)
                puan = 4;
            else if (notu <= 100)
                puan = 5;
            else
                Console.WriteLine("Yanlýþ Not Girdiniz");
            return puan;
        }

    }
}
