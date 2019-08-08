using System;
using System.Text;
namespace Extension
{    
        public static class ExMetod_Int32
        {
            public static int ToInt32(this string deger)
            {
                return Convert.ToInt32(deger);
            }
        }
        public static class ExMetod_Int16
        {
            public static int ToInt16(this string deger)
            {
                return Convert.ToInt16(deger);
            }
        }    
}
