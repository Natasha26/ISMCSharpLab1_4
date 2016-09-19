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

namespace Task2WPF
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
            double m = Convert.ToDouble(TextBox1.Text);
            double n = Convert.ToDouble(TextBox2.Text);
            double z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);
            MessageBox.Show("Значение Z1: " + z1);

        }

            void button2_click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(TextBox1.Text);
            double n = Convert.ToDouble(TextBox2.Text);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            MessageBox.Show("Значение Z2: " + z2);
        }
    }
}
