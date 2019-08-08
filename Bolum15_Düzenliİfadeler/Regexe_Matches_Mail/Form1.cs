using System;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Windows.Forms;
namespace Regexe_Matches_Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            lbldurum.Text = "Siteye Bağlanıyor...";
            WebResponse resp = null;
            try
            {
                WebRequest WebReq = WebRequest.Create(textBox1.Text);
                resp = WebReq.GetResponse();
                lbldurum.Text = "Siteye Bağlandı";
                Stream str = resp.GetResponseStream();
                StreamReader reader = new StreamReader(str);
                string kaynak = reader.ReadToEnd();

                Regex mailDeseni = new Regex
                    ("[\\w-]+(?:\\.[\\w-]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");
                listBox1.Items.Clear();
                foreach (Match isim in mailDeseni.Matches(kaynak))                
                    listBox1.Items.Add(isim.Value);                
                lbldurum.Text = "Bulunan mailler listelendi";
            }
            catch
            {
                lbldurum.Text = "Siteye Bağlanamıyor.";
            }
        }
    }
}
