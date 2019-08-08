using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace excel_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            Excel.Range bulunan = null;           
         int  no, yazilino;
         string sınıf,dosya;
         Boolean aranan_dosya;

         sınıf = Interaction.InputBox("Lütfen sınıfı giriniz");
         aranan_dosya = File.Exists(Application.StartupPath +
         "\\" + sınıf + ".xlsx");

         if (aranan_dosya == false) 
              MessageBox.Show("Sınıf Bulunamadı");
         else
         {
              dosya = Application.StartupPath + "\\" + sınıf + ".xlsx";       
              Excel.Application ExcelApp = new Excel.Application();
              ExcelApp.Workbooks.Open(dosya);               
              ExcelApp.Visible = false; 

              ExcelApp.Worksheets[1].Activate();
              no = Convert.ToInt32(Interaction.InputBox
                  ("Öğrencinin numarasını girin"));
              bulunan = ExcelApp.Cells.Find(What:no);

              if (bulunan==null)
                  MessageBox.Show("Bulunamadı!");
              else
              {
                  bulunan.Activate();
                  yazilino = Convert.ToInt32(Interaction.InputBox
                          ("Kaçıncı yazılıyı öğrenmek istiyorsunuz?"));
                  switch (yazilino)
                  {
                      case 1:
                      {
                        MessageBox.Show("No = " +no +". 1.yazılısı = " + 
                            ExcelApp.Cells[bulunan.Row, bulunan.Column + 1].value);
                        break;
                      }
                      case 2:
                      {
                          MessageBox.Show("No = " + no + ". 2.yazılısı = " + 
                              ExcelApp.Cells[bulunan.Row, bulunan.Column + 2].value);
                        break;
                      }
                      case 3:
                      {
                          MessageBox.Show("No = " + no + ". 3.yazılısı = " + 
                              ExcelApp.Cells[bulunan.Row, bulunan.Column + 3].value);
                        break;
                      }
                  }
              }
              ExcelApp.Application.Quit();
            }
        }
    }
}
