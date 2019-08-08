using System;
using System.Text;


namespace KullanıcıTanımlıException
{
    public class NotKontrol : ApplicationException
    {
        public NotKontrol(string HataMesajı):base(HataMesajı)
        {
        }
    }

}
