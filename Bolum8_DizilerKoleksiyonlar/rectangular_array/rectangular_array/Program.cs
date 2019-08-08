using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[3, 4] 
                { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            for (int i = 0; i < dizi.GetLength(0); i++)            
            {                    
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    Console.Write(dizi[i,j]);
                    if (j == dizi.GetLength(1)-1)
                        Console.WriteLine();
                }                          
            }           
            Console.ReadLine();
        }
    }
}
