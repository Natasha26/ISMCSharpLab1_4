using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuadEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c = double.Parse(Console.ReadLine());

            double D = (b * b) - (4 * a * c);

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.Write("D > 0, x1 = {0}, x2 = {1}\n", x1, x2);
            }
            else if (D == 0)
            {
                double x1 = -b / (2 * a);
                Console.Write("D = 0, x = {0}\n", x1);
            }
            else
            {
                Console.Write("D < 0, решений нет\n");
            }
                   
        }

    }
}

