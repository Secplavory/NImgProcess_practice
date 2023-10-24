using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MYAPP
{
    internal class MyDLL
    {
        [DllImport("MyDLL.dll")]
        public static extern int Add(int a, int b);
        [DllImport("MyDLL.dll")]
        public static extern int Subtract(int a, int b);
        [DllImport("MyDLL.dll")]
        public static extern int Multiply(int a, int b);
        [DllImport("MyDLL.dll")]
        public static extern int Divide(int a, int b);

    }
}
