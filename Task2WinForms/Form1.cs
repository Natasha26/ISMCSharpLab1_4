using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);
            MessageBox.Show("Значение Z1: " + z1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            MessageBox.Show("Значение Z2: " + z2);
        }
    }
}
