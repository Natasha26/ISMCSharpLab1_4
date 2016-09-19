using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            sum += 1.0 / i;
            Console.WriteLine("Сумма: " + sum);

        }
    }
}
