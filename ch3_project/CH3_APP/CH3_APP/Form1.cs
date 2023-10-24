using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CH3CLR;

namespace CH3_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagedClass calclator = new ManagedClass();
            int currentValue = int.Parse(textBox1.Text);
            int result = calclator.Add(currentValue, 30);
            textBox1.Text = result.ToString();
        }
    }
}
