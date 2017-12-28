using System;
using System.Runtime.InteropServices;

namespace Eaa.ChromeCleaner
{
    internal static class Win32
    {
        [DllImport("psapi")]
        public static extern bool EmptyWorkingSet(IntPtr hProcess);
    }
}
