using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MyApp
{
    public class NImageDLL
    {
        [DllImport("NImage.dll")]
        public extern static IntPtr CreateNImage();

        [DllImport("NImage.dll")]
        public extern static bool DestroyNImage(IntPtr m_Img);

        [DllImport("NImage.dll")]
        public extern static bool LoadBMP(IntPtr m_Img, string filename);

        [DllImport("NImage.dll")]
        public extern static IntPtr GetBitmap(IntPtr m_Img);
    }
}
