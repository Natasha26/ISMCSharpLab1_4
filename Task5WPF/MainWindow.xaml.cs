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

namespace Task5WPF
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
            double x = Convert.ToDouble(TextBox1.Text);
            double y = Convert.ToDouble(TextBox2.Text);
            double z = Convert.ToDouble(TextBox3.Text);
            double t = 2 * Math.Cos(x - Math.PI / 6) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
            MessageBox.Show("t= " + t);

        }
    }
}
