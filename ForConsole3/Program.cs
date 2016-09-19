using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            double c = 1;
            for (double i = 1; i <= n; i++)
                c *= a;
            Console.WriteLine("А в степени N = " + c);
        }
    }
}
