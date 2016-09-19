using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.Write("Результат: ");
            Console.WriteLine(y);
        }
    }
}
