﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexno;
            string aranan;
            Array okulturu = Array.CreateInstance(typeof(string), 3);
            okulturu.SetValue("Endüstri Meslek", 0);
            okulturu.SetValue("Teknik", 1);
            okulturu.SetValue("Anadolu Teknik", 2);
            Console.Write("Aranan değeri giriniz:");
            aranan = Console.ReadLine();
            indexno = Array.IndexOf(okulturu, aranan.ToString());
            if (indexno == -1)
            {
                Console.Write("Aranan değer bulunamadı");
            }
            else
            {
                Console.Write("Aranan eleman bulundu.İndex değeri = " +
             indexno);
            }
            Console.ReadKey();
        }
    }
}
