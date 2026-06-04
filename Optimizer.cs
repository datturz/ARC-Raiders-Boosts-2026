using System;
using System.Runtime.InteropServices;

namespace ArcRaidersBooster
{
    public class Optimizer
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        
        public static void MinimizeMemoryUsage()
        {
            try
            {
                IntPtr pProcess = Process.GetCurrentProcess().Handle;
                SetProcessWorkingSetSize(pProcess, -1, -1);
            }
            catch (Exception)
            {
                // Silent catch to prevent errors on older Windows versions
            }
        }
    }
}