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

namespace Task4WPF
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
            double f = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3.0), 1.0 / 4.0) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2.0) + Math.Tan(z)));
            MessageBox.Show("f= " + f);

        }
    }
}
