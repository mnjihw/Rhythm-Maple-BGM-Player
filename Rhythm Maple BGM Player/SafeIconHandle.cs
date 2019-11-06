using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rhythm_Maple_BGM_Player
{
    class SafeIconHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyIcon([In] IntPtr hIcon);
        private SafeIconHandle() : base(true) { }
        public SafeIconHandle(IntPtr hIcon) : base(true) => SetHandle(hIcon);
        protected override bool ReleaseHandle() => DestroyIcon(handle); 
    }

    
     

}
