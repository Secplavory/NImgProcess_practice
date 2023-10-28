
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CH5_APP
{
    internal class NImageProcessDLL
    {
        [DllImport("NImgProcess.dll")]
        public extern static void OtsuThreshold(IntPtr m_img);
        [DllImport("NImgProcess.dll")]
        public extern static int KSW_EntropicThreshold(IntPtr m_img);
        [DllImport("NImgProcess.dll")]
        public extern static int MomentThreshold(IntPtr m_img);
    }
}