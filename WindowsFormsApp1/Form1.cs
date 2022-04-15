using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,5";
            textBox2.Text = "2,2";
            textBox3.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text += "При Х = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
            double c;
            if ((x - y) == 0)
                c = Math.Exp(x) * Math.Exp(x) + y * y + Math.Sin(y);
            else
                if ((x - y) > 0)
                c = Math.Pow(Math.Exp(x) - y, 2) + Math.Cos(y);
            else
                c = Math.Pow(y - Math.Exp(x), 2) + Math.Tan(y);
            textBox4.Text += "C = " + c.ToString() + Environment.NewLine;
        }

    }
}

