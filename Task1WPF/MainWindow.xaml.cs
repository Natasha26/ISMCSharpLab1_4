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

namespace Task1WPF
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
                uint a = uint.Parse(TextBox1.Text);
                uint b = uint.Parse(TextBox2.Text);
                uint x = 2 * (a + b);
                MessageBox.Show("Периметр прямоугольника: " + x);

            }

            void button2_click(object sender, EventArgs e)
            {
                uint a = uint.Parse(TextBox1.Text);
                uint b = uint.Parse(TextBox2.Text);
                uint y = a * b;
                MessageBox.Show("Площадь прямоугольника: " + y);
            
        }
    }
}
