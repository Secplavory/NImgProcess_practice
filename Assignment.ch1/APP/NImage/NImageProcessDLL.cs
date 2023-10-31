using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class NImageProcessDLL
    {
        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageProcessDLL.dll")]
        public extern static void OtsuThreshold(IntPtr m_img);
        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageProcessDLL.dll")]
        public extern static int KSW_EntropicThreshold(IntPtr m_img);
        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageProcessDLL.dll")]
        public extern static int MomentThreshold(IntPtr m_img);
    }
}
