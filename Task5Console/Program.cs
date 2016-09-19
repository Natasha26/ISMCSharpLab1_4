using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение z: ");
            double z = double.Parse(Console.ReadLine());
            double t = 2 * Math.Cos(x - Math.PI/6) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
            Console.Write("Результат: ");
            Console.WriteLine(t);

        }
    }
}
