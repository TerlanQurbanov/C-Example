using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    //sealed class Hesapla    
    class Hesapla    
    {

        public int yazılı1 { get; set; }
        public int yazılı2 { get; set; }
        public int sozlu { get; set; }
        //sealed public virtual double islem()
        public virtual double islem()
        {
            double sonuc = (yazılı1 + yazılı2 + sozlu) / 3;
            return (sonuc);
        }       
    }
    class Turemis_Sınıf : Hesapla
    {
        public int odev { get; set; }
        public override double islem()
        //new public double islem()
        {
            double sonuc = (yazılı1 + yazılı2 + sozlu + odev) / 4;
            return (sonuc);
        }
    }
}
