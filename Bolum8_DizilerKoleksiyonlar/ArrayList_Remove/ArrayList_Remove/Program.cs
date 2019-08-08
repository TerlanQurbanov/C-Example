using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nickname = new ArrayList();
            nickname.Add("Talha");
            nickname.Add(123);
            nickname.Add("a");
            nickname.Remove(123);
            Console.Write(nickname[1]);
            Console.ReadKey();
        }
    }
}
