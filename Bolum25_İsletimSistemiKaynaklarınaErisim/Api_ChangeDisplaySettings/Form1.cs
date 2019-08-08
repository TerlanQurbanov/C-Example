using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Api_ChangeDisplaySettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
public struct DEVMODE
{
    public const int CCHDEVICENAME = 32;
    public const int CCHFORMNAME = 32;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
    [System.Runtime.InteropServices.FieldOffset(0)]
    public string dmDeviceName;
    [System.Runtime.InteropServices.FieldOffset(32)]
    public Int16 dmSpecVersion;
    [System.Runtime.InteropServices.FieldOffset(34)]
    public Int16 dmDriverVersion;
    [System.Runtime.InteropServices.FieldOffset(36)]
    public Int16 dmSize;
    [System.Runtime.InteropServices.FieldOffset(38)]
    public Int16 dmDriverExtra;
    [System.Runtime.InteropServices.FieldOffset(40)]
    public DM dmFields;
    [System.Runtime.InteropServices.FieldOffset(40)]        
    Int16 dmOrientation;
    [System.Runtime.InteropServices.FieldOffset(46)]
    Int16 dmPaperSize;
    [System.Runtime.InteropServices.FieldOffset(48)]
    Int16 dmPaperLength;
    [System.Runtime.InteropServices.FieldOffset(50)]
    Int16 dmPaperWidth;
    [System.Runtime.InteropServices.FieldOffset(52)]
    Int16 dmScale;
    [System.Runtime.InteropServices.FieldOffset(54)]
    Int16 dmCopies;
    [System.Runtime.InteropServices.FieldOffset(56)]
    Int16 dmDefaultSource;
    [System.Runtime.InteropServices.FieldOffset(58)]
    Int16 dmPrintQuality;   
    [System.Runtime.InteropServices.FieldOffset(52)]
    public Int32 dmDisplayOrientation;
    [System.Runtime.InteropServices.FieldOffset(56)]
    public Int32 dmDisplayFixedOutput;
    [System.Runtime.InteropServices.FieldOffset(60)]
    public short dmColor;
    [System.Runtime.InteropServices.FieldOffset(62)]
    public short dmDuplex;
    [System.Runtime.InteropServices.FieldOffset(64)]
    public short dmYResolution;
    [System.Runtime.InteropServices.FieldOffset(66)]
    public short dmTTOption;
    [System.Runtime.InteropServices.FieldOffset(68)]
    public short dmCollate;
    [System.Runtime.InteropServices.FieldOffset(72)]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
    public string dmFormName;
    [System.Runtime.InteropServices.FieldOffset(102)]
    public Int16 dmLogPixels;
    [System.Runtime.InteropServices.FieldOffset(104)]
    public Int32 dmBitsPerPel;
    [System.Runtime.InteropServices.FieldOffset(108)]
    public Int32 dmPelsWidth;
    [System.Runtime.InteropServices.FieldOffset(112)]
    public Int32 dmPelsHeight;
    [System.Runtime.InteropServices.FieldOffset(116)]
    public Int32 dmDisplayFlags;
    [System.Runtime.InteropServices.FieldOffset(116)]
    public Int32 dmNup;
    [System.Runtime.InteropServices.FieldOffset(120)]
    public Int32 dmDisplayFrequency;
}

[Flags()]
public enum DM : int
{
    Orientation = 0x1,
    PaperSize = 0x2,
    PaperLength = 0x4,
    PaperWidth = 0x8,
    Scale = 0x10,
    Position = 0x20,
    NUP = 0x40,
    DisplayOrientation = 0x80,
    Copies = 0x100,
    DefaultSource = 0x200,
    PrintQuality = 0x400,
    Color = 0x800,
    Duplex = 0x1000,
    YResolution = 0x2000,
    TTOption = 0x4000,
    Collate = 0x8000,
    FormName = 0x10000,
    LogPixels = 0x20000,
    BitsPerPixel = 0x40000,
    PelsWidth = 0x80000,
    PelsHeight = 0x100000,
    DisplayFlags = 0x200000,
    DisplayFrequency = 0x400000,
    ICMMethod = 0x800000,
    ICMIntent = 0x1000000,
    MediaType = 0x2000000,
    DitherType = 0x4000000,
    PanningWidth = 0x8000000,
    PanningHeight = 0x10000000,
    DisplayFixedOutput = 0x20000000
}
public enum DISP_CHANGE : int
{
    Successful = 0,
    Restart = 1,
    Failed = -1,
    BadMode = -2,
    NotUpdated = -3,
    BadFlags = -4,
    BadParam = -5,
    BadDualView = -1
}

[DllImport("user32.dll")]
public static extern bool EnumDisplaySettings(string lpszDeviceName, 
int iModeNum, ref DEVMODE lpDevMode);
[DllImport("user32.dll")]
public static extern DISP_CHANGE ChangeDisplaySettings(ref DEVMODE devMode, 
int flags); 
DEVMODE vDevMode = new DEVMODE();

        private void btnCozunurlukBul_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 0;
            while ((EnumDisplaySettings(null, i, ref vDevMode)))
            {
                listBox1.Items.Add("Genişlik = " + vDevMode.dmPelsWidth + " " +
                    "Yükseklik= " + vDevMode.dmPelsHeight + " " + "Frekans= " +
                    vDevMode.dmDisplayFrequency + " hertz");
                i += 1;
            }
            Screen ekran = Screen.PrimaryScreen;
            lblAktifCozunurluk.Text = "Aktif Çözünürlük= " + ekran.Bounds.Width +
                "X" + ekran.Bounds.Height;
        }

        private void btnCozunurlukDegistir_Click(object sender, EventArgs e)
        {
            DISP_CHANGE changeResult;
            const int ENUM_CURRENT_SETTINGS = -1;
            bool enumResult;

            enumResult = EnumDisplaySettings(vDevMode.dmDeviceName,
                ENUM_CURRENT_SETTINGS, ref vDevMode);
            vDevMode.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            vDevMode.dmPelsWidth = 800;
            vDevMode.dmPelsHeight = 600;
            vDevMode.dmDisplayFrequency = 60;

            changeResult = ChangeDisplaySettings(ref vDevMode, 0);
            if (changeResult != DISP_CHANGE.Successful)            
                throw new Exception("Hata oluştu!" + changeResult.ToString());           
            else           
                MessageBox.Show("Çözünürlük ayarları değiştirildi");
        }
    }
}
