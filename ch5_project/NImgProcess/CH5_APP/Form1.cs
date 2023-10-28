using MyApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH5_APP
{
    public partial class Form1 : Form
    {
        public IntPtr m_Img = NImageDLL.CreateNImage();
        public IntPtr hbitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BMP file |*.bmp";
            string path;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                if (NImageDLL.LoadBMP(m_Img, path))
                {
                    hbitmap = NImageDLL.GetBitmap(m_Img);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = System.Drawing.Image.FromHbitmap(hbitmap);
                    pictureBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("ERROR", "ERROR");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
            if (NImageDLL.LoadBMP(m_Img, path))
            {
                NImageProcessDLL.OtsuThreshold(m_Img);
                hbitmap = NImageDLL.GetBitmap(m_Img);
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = System.Drawing.Image.FromHbitmap(hbitmap);
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
            if (NImageDLL.LoadBMP(m_Img, path))
            {
                NImageProcessDLL.KSW_EntropicThreshold(m_Img);
                hbitmap = NImageDLL.GetBitmap(m_Img);
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = System.Drawing.Image.FromHbitmap(hbitmap);
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
            if (NImageDLL.LoadBMP(m_Img, path))
            {
                NImageProcessDLL.MomentThreshold(m_Img);
                hbitmap = NImageDLL.GetBitmap(m_Img);
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = System.Drawing.Image.FromHbitmap(hbitmap);
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }
        }
    }
}
