using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuadEquationWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        void button1_click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            double c = Convert.ToDouble(TextBox3.Text);
            double D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                TextBox4.Text = D.ToString();
                TextBox5.Text = x1.ToString();
                TextBox6.Text = x2.ToString();
                TextBox5.Visibility = Visibility.Visible;
                TextBox6.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
                label6.Visibility = Visibility.Visible;
            }
            else if (D == 0)
            {
                double x1 = -b / (2 * a);
                TextBox4.Text = D.ToString();
                TextBox5.Text = x1.ToString();
                label6.Visibility = Visibility.Hidden;
                TextBox6.Visibility = Visibility.Hidden;

            }
            else
            {
                TextBox4.Text = "D < 0";
                label5.Visibility = Visibility.Hidden;
                label6.Visibility = Visibility.Hidden;
                TextBox5.Visibility = Visibility.Hidden;
                TextBox6.Visibility = Visibility.Hidden;
                MessageBox.Show("Решений нет");

            }


        }

    }
    }

