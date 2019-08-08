using System;
using System.Text;
using System.Windows.Forms;
namespace Params_Class
{
    public class snf_aktif_pasif
    {
        byte i;
        public void mtd_aktif(params Button[] btn)
        {
            for (i = 0; i <= btn.Length - 1; i++)
            {
                btn[i].Enabled = true;
            }
        }
        public void mtd_pasif(params Button[] btn)
        {
            for (i = 0; i <= btn.Length - 1; i++)
            {
                btn[i].Enabled = false;
            }
        }
    }
}
