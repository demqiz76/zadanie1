using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        string s;
        double a;
        double b;
        double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = Convert.ToDouble(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            b = Convert.ToDouble(s);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }
    }
}
