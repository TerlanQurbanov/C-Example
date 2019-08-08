using System;
using System.Text;
using System.Runtime.InteropServices;
namespace Api_GetSystemInfo
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern void GetSystemInfo
            ([MarshalAs(UnmanagedType.Struct)] 
            ref SYSTEM_INFO lpSystemInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            internal _PROCESSOR_INFO_UNION uProcessorInfo;
            public uint dwPageSize;
            public IntPtr lpMinimumApplicationAddress;
            public IntPtr lpMaximumApplicationAddress;
            public IntPtr dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public ushort dwProcessorLevel;
            public ushort dwProcessorRevision;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct _PROCESSOR_INFO_UNION
        {
            [FieldOffset(0)]
            internal uint dwOemId;
            [FieldOffset(0)]
            internal ushort wProcessorArchitecture;
            [FieldOffset(2)]
            internal ushort wReserved;
        }
        static void Main(string[] args)
        {
            SYSTEM_INFO sysinfo = new SYSTEM_INFO();
            GetSystemInfo(ref sysinfo);

            switch (sysinfo.uProcessorInfo.wProcessorArchitecture)
            {
                case 9:
                    Console.WriteLine("İşlemci Tipi = AMDx64");
                    break;
                case 6:
                    Console.WriteLine("İşlemci Tipi = Itaniumx64");
                    break;
                case 0:
                    Console.WriteLine("İşlemci Tipi = Intelx86");
                    break;
                default:
                    Console.WriteLine("İşlemci Tipi bilinmiyor");
                    break;
            }
            Console.WriteLine("İşlemci Sayısı = " +
                sysinfo.dwNumberOfProcessors.ToString());
            Console.WriteLine("Cache Bellek Miktarı = " +
                sysinfo.dwPageSize.ToString());
            Console.ReadKey();

        }
    }
}
