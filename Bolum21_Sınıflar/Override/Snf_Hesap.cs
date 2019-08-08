using System;
namespace Override
{
    //class Hesapla
    
    abstract class Hesapla
    {
        
        public int yazılı1 { get; set; }
        public int yazılı2 { get; set; }
        public int sozlu { get; set; }
        //public virtual double islem()
        //{
            //double sonuc = (yazılı1 + yazılı2 + sozlu) / 3;
            //return (sonuc);
        //}
        abstract public double islem();
    }
    class Turemis_Sınıf : Hesapla
    {        
        public int odev { get; set; }
        public override double islem()
        //new public double islem()
        {
            double sonuc = (yazılı1 + yazılı2 + sozlu + odev)/4;
            return (sonuc);
        }
    }
}
