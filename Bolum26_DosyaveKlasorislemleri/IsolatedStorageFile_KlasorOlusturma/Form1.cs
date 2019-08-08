using System;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
namespace IsolatedStorageFile_KlasorOlusturma
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
        }
    }
}
