﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYAPP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(textBox1.Text);
            currentValue = MyDLL.Add(currentValue, 30);
            textBox1.Text = currentValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(textBox1.Text);
            currentValue = MyDLL.Subtract(currentValue, 30);
            textBox1.Text = currentValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(textBox1.Text);
            currentValue = MyDLL.Multiply(currentValue, 30);
            textBox1.Text = currentValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(textBox1.Text);
            currentValue = MyDLL.Divide(currentValue, 30);
            textBox1.Text = currentValue.ToString();
        }
    }
}
