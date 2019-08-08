using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
namespace Xml_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            XDocument myXML = XDocument.Load("list.xml");
            var arkadaslar = from kisi in myXML.Descendants("Kisi") select kisi;
            //var arkadaslar = from kisi in myXML.Descendants("Kisi") select kisi.Element("isim").Value;

            foreach (var veri in arkadaslar)
                MessageBox.Show(veri.Element("isim").Value.ToString() + "-" + veri.Element("site").Value.ToString());
                //MessageBox.Show(veri.ToString());
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            XDocument myXML = XDocument.Load("list.xml");
            XElement xmlekle = new XElement("Kisi");
            xmlekle.Add(new XElement("isim", "Volkan AKTAŞ"));
            xmlekle.Add(new XElement("site", "http://www.volkanaktas.com/"));
            myXML.Element("Arkadaslar").Add(xmlekle);
            myXML.Save("list.xml");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            XDocument myXML = XDocument.Load("list.xml");
            var eleman = (from veri in myXML.Descendants("Kisi")
                          where
                              veri.Element("isim").Value == "Selçuk Ermaya"
                          select veri).SingleOrDefault();

            ((XElement)eleman).Element("site").SetValue("http://www.blogsa.net/");
            myXML.Save("list.xml");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            XDocument myXML = XDocument.Load("list.xml");
            var eleman = (from veri in myXML.Descendants("Kisi")
                          where
                              veri.Element("isim").Value == "Selçuk Ermaya"
                          select veri).SingleOrDefault();
            eleman.Remove();
            myXML.Save("list.xml");
        }
    }
}
