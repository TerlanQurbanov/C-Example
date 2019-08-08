using System;
using System.Windows.Forms;
using System.IO;
namespace Directory_GetDirectories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Klasör Listesi");
        }

        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
            string[] klasorler = Directory.
                GetDirectories(txtKlasorAdı.Text);
            treeView1.Nodes[0].Text = txtKlasorAdı.Text;
            TreeNode anadugum = treeView1.Nodes[0];

            if (klasorler.Length != 0)
            {
                foreach (string aktifklasor in klasorler)
                {
                    TreeNode dugum = new TreeNode(aktifklasor);
                    anadugum.Nodes.Add(dugum);
                }
            }
            treeView1.ExpandAll();
            string[] dosyalar = Directory.GetFiles(txtKlasorAdı.Text);
            foreach (string aktifdosya in dosyalar)
                listBox1.Items.Add(aktifdosya);
            txtErisimZamanı.Text = Directory.
                GetLastAccessTime(txtKlasorAdı.Text).ToString();
            txtOlusturulmaZamanı.Text = Directory.
                GetCreationTime(txtKlasorAdı.Text).ToString();
            txtYazımZamanı.Text = Directory.
                GetLastWriteTime(txtKlasorAdı.Text).ToString();
        }
    }
}
