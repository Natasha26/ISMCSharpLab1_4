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

namespace ForConsole6
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
            
            double n = Convert.ToDouble(TextBox1.Text);
            double c = 0.0;
            double d = n;
            for (int i = 1; i <= d; i++, d--)
                c += (i * (n - i + 1));
            MessageBox.Show("summ = " + c);

        }
    }
}

