using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите значение m: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите значение n: ");
            double n = double.Parse(Console.ReadLine());
            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
            Console.Write("Значение z1: ");
            Console.WriteLine(z1);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.Write("Значение z2: ");
            Console.WriteLine(z2);

        }
    }
}
