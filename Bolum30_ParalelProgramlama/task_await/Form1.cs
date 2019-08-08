using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
namespace task_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            foreach (string adresler in textBox1.Lines)
                islemyap(adresler);
        }
        //private void islemyap(string adres)
        private async void islemyap(string adres)
        {
            var kaynak = new MemoryStream();    
            var webReq = (HttpWebRequest)WebRequest.Create(adres);            
            //using (var resp = webReq.GetResponse())    
            using (var resp = await webReq.GetResponseAsync())
            {                
                using (Stream respStream = resp.GetResponseStream())             
                    //respStream.CopyTo(kaynak);        
                    await respStream.CopyToAsync(kaynak);

            }    
            //return kaynak.ToArray();             
            Regex mailDeseni = new Regex
                ("[\\w-]+(?:\\.[\\w-]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");

            foreach (Match isim in mailDeseni.Matches(Encoding.ASCII.GetString(kaynak.ToArray())))
                listBox1.Items.Add(isim.Value);
        }
    }
}