using System;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;
namespace IsolatedStorageFile_DosyayaYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IsolatedStorageFile isf = IsolatedStorageFile.
            GetUserStoreForAssembly();
        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            if (txtKlasor.Text != "")
                isf.CreateDirectory(txtKlasor.Text);

            if (txtDosya.Text != "")
            {
                IsolatedStorageFileStream isf_fst = new
                    IsolatedStorageFileStream(txtKlasor.Text + "\\" +
                    txtDosya.Text, FileMode.OpenOrCreate, isf);
                StreamWriter str_wrt = new StreamWriter(isf_fst);
                str_wrt.Write(txticerik.Text);
                str_wrt.Flush();
                str_wrt.Close();
            }
        }
    }
}
