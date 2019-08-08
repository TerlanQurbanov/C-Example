using System;
using System.Runtime.CompilerServices;
using System.Text;
namespace Caller_Info_Attributes
{
    class Program
    {
        static void bilgi([CallerMemberName] string metodismi = "",[CallerFilePath] string dosyayolu = "",[CallerLineNumber] int satırnumarası = 0)
        {
            Console.WriteLine("Uygulama yolu= " +dosyayolu);
            Console.WriteLine("Çağıran metod ismi= " +metodismi);
            Console.WriteLine("Çağıran satır numarası= "+satırnumarası);
        }
        static void Main(string[] args)
        {
            bilgi();
            Console.ReadLine();
        }
    }
}
