using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Clear
{
    class Program
    {
        static void Main(string[] args)
        {
            string yazi = "KodLab";
            StringBuilder sb = new StringBuilder();
            sb.Append(yazi.ToString());
            Console.WriteLine(sb.Length.ToString());
            sb.Clear();
            Console.WriteLine(sb.Length.ToString());
            Console.ReadKey();

        }
    }
}
