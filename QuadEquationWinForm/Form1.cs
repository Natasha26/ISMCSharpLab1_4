using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double D = (b * b) - (4 * a * c);
            

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                textBox4.Text = D.ToString();
                textBox5.Text = x1.ToString();
                textBox6.Text = x2.ToString();               
                textBox5.Visible = true;
                textBox6.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else if (D == 0)
            {
                double x1 = -b / (2 * a);
                textBox4.Text = D.ToString();
                textBox5.Text = x1.ToString();
                label6.Visible = false;
                textBox6.Visible = false;
                
            }
            else
            {
                textBox4.Text = "D < 0";
                textBox5.Visible = false;
                textBox6.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                MessageBox.Show("Решений нет");

            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
