using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_parse
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
            uzmanlık uzmanlıkalanı = (uzmanlık)Enum.Parse
                (typeof(uzmanlık), "CSharp", true);
            Console.WriteLine("CSharp uzmanlık alanının değeri = {0}",
                uzmanlıkalanı.ToString("D"));
            Console.ReadLine();

        }
    }
}
