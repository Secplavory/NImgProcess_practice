using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class NImageDLL
    {
        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageDLL.dll")]
        public extern static IntPtr CreateNImage();

        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageDLL.dll")]
        public extern static bool DestroyNImage(IntPtr m_Img);

        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageDLL.dll")]
        public extern static bool LoadBMP(IntPtr m_Img, string filename);
        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageDLL.dll")]
        public extern static bool SaveBMP(IntPtr m_Img, string filename);
        [DllImport(@"D:\sourcetree\NImgProcess_practice\Assignment.ch1\x64\Debug\NImageDLL.dll")]
        public extern static IntPtr GetBitmap(IntPtr m_Img);
        
    }
}
