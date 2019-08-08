using System;
using System.Text;
using System.Windows.Forms;
namespace aktif_pasif_dll
{
    /// <summary>
    /// snf_aktif_pasif sınıfı form üzerindeki butonların
    /// aktif ve pasif yapılabilmesi için gerekli metodları sunar.
    /// </summary>
    public class snf_aktif_pasif
    {
        byte i;
        /// <summary>
        /// Parametre olarak gelen buton dizisini (btn) aktif 
        /// yapmak için kullanılır.
        /// </summary>
        /// <param name="btn">Aktif yapılacak buton dizisi. Örneğin 
        ///"Button1,Button2" şeklinde</param>
        /// <remarks></remarks>
        public void mtd_aktif(params Button[] btn)
        {
            for (i = 0; i <= btn.Length - 1; i++)            
                btn[i].Enabled = true;            
        }
        /// <summary>
        /// Parametre olarak gelen buton dizisini (btn) pasif 
        /// yapmak için kullanılır.        
        /// </summary>
        /// <param name="btn">Pasif yapılacak buton dizisi. Örneğin 
        ///"Button1,Button2" şeklinde</param>
        /// <remarks></remarks>
        public void mtd_pasif(params Button[] btn)
        {
            for (i = 0; i <= btn.Length - 1; i++)           
                btn[i].Enabled = false;            
        }
    }
}
