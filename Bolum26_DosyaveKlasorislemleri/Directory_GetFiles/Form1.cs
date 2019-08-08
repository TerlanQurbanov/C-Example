using System;
using System.IO;
using System.Windows.Forms;

namespace Directory_GetFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //string kullanıcı = Environment.UserName;
            string yol = Environment.
          GetEnvironmentVariable("HOMEDRIVE") +
                System.Environment.GetEnvironmentVariable
          ("HOMEPATH");

            string[] cookies = Directory.GetFiles(yol +
                @"\AppData\Roaming\Microsoft\Windows\cookies\", "*.*");
            label1.Text = cookies.Length + " adet dosya silindi";

            foreach (string dosya in cookies)
            {
                try
                {
                    File.Delete(dosya);
                }
                catch (Exception ex)
                { }
            }

        }
    }
}
