using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_GetName
{
    class Program
    {
        [Flags()]
        enum uzmanlık
        {
            VBNet = 1,
            PHP = 2,
            ASPNet = 4,
            CSharp = 8
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Enum.GetName(typeof(uzmanlık), 8));
            Console.ReadLine();
        }
    }
}
