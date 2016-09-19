using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double f = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3.0), 1.0 / 4.0) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2.0) + Math.Tan(z)));
            MessageBox.Show("f= " + f);
        }
    }
}
