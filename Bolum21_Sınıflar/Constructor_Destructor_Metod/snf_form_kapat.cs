using System;
using System.Windows.Forms;
using System.Text;
namespace Constructor_Destructor_Metod
{
    class snf_form_kapat
    {
        public snf_form_kapat()
        {
            MessageBox.Show("Sınıf Aktif");
        }
        ~snf_form_kapat()
        {
            MessageBox.Show("Sınıf Pasif");
        }
        public void mtd_kapat(Form frm)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak İster misiniz",
                    "Çıkış", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
                frm.Close();
        }
    }
}
