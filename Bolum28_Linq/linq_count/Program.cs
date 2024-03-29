﻿using System;
using System.Linq;
using System.Text;
namespace linq_count
{
    class Program
    {
        public struct ogrenci
        {
            public string ad;
            public string soyad;
            public int numara;
            public string sınıf;
        }
        static void Main(string[] args)
        {
            ogrenci[] ogrenciler = new ogrenci[3];
            ogrenciler[0].ad = "Talha";
            ogrenciler[0].soyad = "AKTAŞ";
            ogrenciler[0].numara = 151;
            ogrenciler[0].sınıf = "3-C";

            ogrenciler[1].ad = "Sümeyye";
            ogrenciler[1].soyad = "AKTAŞ";
            ogrenciler[1].numara = 133;
            ogrenciler[1].sınıf = "1-A";

            ogrenciler[2].ad = "Musab";
            ogrenciler[2].soyad = "ÇELİK";
            ogrenciler[2].numara = 144;
            ogrenciler[2].sınıf = "3-C";

            var sayı = (from ogr in ogrenciler
                        where
                            ogr.numara > 140
                        select ogr.numara).Count();
            Console.WriteLine
                        ("Numarası 140'dan büyük olanların sayısı= " + sayı);
            Console.ReadKey();
        }
    }
}
