using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miras_SayiTuretme
{
    class Temel_Sinif
    {
        public int mtd_sayi_turet(int x, int y)
        {
            int rtrn = 0;
            System.Random rnd = new Random();
            rtrn = rnd.Next(x, y);
            return rtrn;
        }
        public class snf_mirascı : Temel_Sinif
        {
            public object mtd_turet()
            {
                int sayi = 0;
                sayi = mtd_sayi_turet(0, 100);
                return sayi;
            }
        }
    }
}
