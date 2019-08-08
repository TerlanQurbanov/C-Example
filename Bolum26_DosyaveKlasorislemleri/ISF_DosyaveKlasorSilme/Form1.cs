using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
namespace ISF_DosyaveKlasorSilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IsolatedStorageFile isf = IsolatedStorageFile.GetStore
            (IsolatedStorageScope.User | IsolatedStorageScope.Assembly |
            IsolatedStorageScope.Domain, typeof(System.Security.Policy.Url),
            typeof(System.Security.Policy.Url));
        string klasoradi, dosyaadi;
        string[] klasorler, dosyalar;
        private void btnListele_Click(object sender, EventArgs e)
        {
            BilgiAl();
            if (klasorler.Length > 0)
                foreach (string isim in klasorler)
                    lstKlasor.Items.Add(isim);
            if (dosyalar.Length > 0)
                foreach (string isim in dosyalar)
                    lstDosya.Items.Add(isim);

            isf.Close();
        }
        private void BilgiAl()
        {
            lstKlasor.Items.Clear();
            lstDosya.Items.Clear();
            klasorler = isf.GetDirectoryNames("*");
            dosyalar = isf.GetFileNames("*");
        }
        private void lstKlasor_SelectedIndexChanged(object sender, EventArgs e)
        {
            klasoradi = lstKlasor.SelectedItem.ToString();
            lstDosya.Items.Clear();

            IsolatedStorageFile isf = IsolatedStorageFile.GetStore
                (IsolatedStorageScope.User | IsolatedStorageScope.Assembly |
                IsolatedStorageScope.Domain, typeof(System.Security.Policy.Url),
                typeof(System.Security.Policy.Url));

            lstDosya.Items.AddRange(isf.GetFileNames(Path.Combine
          (klasoradi, "*")));
        }
        private void lstDosya_SelectedIndexChanged(object sender, EventArgs e)
        {
            dosyaadi = lstDosya.SelectedItem.ToString();
            IsolatedStorageFileStream isf_fst = new IsolatedStorageFileStream
                (Path.Combine(klasoradi, dosyaadi), FileMode.Open, isf);
            StreamReader str_rdr = new StreamReader(isf_fst);
            textBox1.Text = str_rdr.ReadToEnd();
            str_rdr.Close();
            isf_fst.Close();
        }
        private void btnKlasorSil_Click(object sender, EventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetStore
                (IsolatedStorageScope.User | IsolatedStorageScope.Assembly |
                IsolatedStorageScope.Domain, typeof(System.Security.Policy.Url),
                typeof(System.Security.Policy.Url));

            isf.DeleteDirectory(lstKlasor.SelectedItem.ToString());
            klasoradi = string.Empty;
            lstKlasor.Refresh();
            MessageBox.Show("Seçili olan klasör silindi");
        }
        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetStore
                (IsolatedStorageScope.User | IsolatedStorageScope.Assembly |
                IsolatedStorageScope.Domain, typeof(System.Security.Policy.Url),
                typeof(System.Security.Policy.Url));

            isf.DeleteFile(Path.Combine(klasoradi,
                lstDosya.SelectedItem.ToString()));
            dosyaadi = string.Empty;
            lstDosya.Refresh();
            MessageBox.Show("Seçili olan dosya silindi");
        }
        private void btnDosyaOlustur_Click(object sender, EventArgs e)
        {
            if (txtKlasor.Text != "")
                isf.CreateDirectory(txtKlasor.Text);
            if (txtDosya.Text != "")
            {
                IsolatedStorageFileStream isf_fst = new IsolatedStorageFileStream
                    (txtKlasor.Text + "\\" + txtDosya.Text, FileMode.OpenOrCreate,
                    FileAccess.Write, isf);

                StreamWriter str_wrt = new StreamWriter(isf_fst);
                str_wrt.Write(txticerik.Text);
                str_wrt.Flush();
                str_wrt.Close();
            }
        }
    }
}
