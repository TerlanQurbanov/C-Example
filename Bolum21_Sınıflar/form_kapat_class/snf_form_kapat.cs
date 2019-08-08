using System;
using System.Text;
using System.Windows.Forms;
namespace form_kapat_class
{
    class snf_form_kapat
    {
        //public void mtd_kapat(Form frm)
        public static void mtd_kapat(Form frm)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak İster misiniz",
                    "Çıkış", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
                    frm.Close();
        }
    }
}
