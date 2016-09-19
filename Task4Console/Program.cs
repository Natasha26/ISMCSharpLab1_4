using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
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
            double f = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3.0), 1.0 / 4.0) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2.0) + Math.Tan(z)));
            Console.Write("Результат: ");
            Console.WriteLine(f);
        }
    }
}
