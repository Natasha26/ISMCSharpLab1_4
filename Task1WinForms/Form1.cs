using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint a = uint.Parse(textBox1.Text);
            uint b = uint.Parse(textBox2.Text);
            uint x = 2 * (a + b);
            MessageBox.Show("Периметр прямоугольника: " + x);      
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uint a = uint.Parse(textBox1.Text);
            uint b = uint.Parse(textBox2.Text);
            uint y = a * b;
            MessageBox.Show("Площадь прямоугольника: " + y);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
