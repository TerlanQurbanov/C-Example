using System;
using System.ComponentModel;

namespace INotifyPropertyChanged_Interface
{
    class Bilgi : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string ad = string.Empty;
        string soyad = string.Empty;

        public string Ad
        {
            get { return ad; }
            set
            {
                if (value != ad)
                {
                    ad = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Ad"));                        
                    }
                }
            }
        }
        public string Soyad
        {
            get { return soyad; }
            set
            {
                if (value != soyad)
                {
                    soyad = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Soyad"));                        
                    }
                }
            }
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bilgi = new Bilgi { Ad = "Volkan", Soyad = "Aktaş" };
            bilgi.PropertyChanged += (sender, e) => Console.WriteLine(string.Format("{0} değişti.", e.PropertyName));
            bilgi.Ad = "Talha Osman";
            bilgi.Soyad = "Aktaş";
            Console.ReadLine();
        }
    }
}
