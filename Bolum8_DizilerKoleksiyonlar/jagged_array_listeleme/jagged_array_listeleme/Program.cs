using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_listeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] duzensiz_dizi = { new int[] { 1}, 
              //         	  new int[] { 1, 2, 3 }, 
                //          new int[] { 1, 2 } };
            int[][] duzensiz_dizi = new int[3][];
            
            duzensiz_dizi[0] = new int[1];
            duzensiz_dizi[1] = new int[3];
            duzensiz_dizi[2] = new int[2];

            duzensiz_dizi[0][0] = 1;
            duzensiz_dizi[1][0] = 1;
            duzensiz_dizi[1][1] = 2;
            duzensiz_dizi[1][2] = 3;
            duzensiz_dizi[2][0] = 1;
            duzensiz_dizi[2][1] = 2;

            foreach (var satir in duzensiz_dizi)
            {                
                foreach (var eleman in satir)
                    Console.Write("{0}  ", eleman);
                Console.WriteLine(); 
            }
            Console.ReadLine();
        }
    }
}
