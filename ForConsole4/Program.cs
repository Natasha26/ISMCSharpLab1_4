using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            double c = 1;
            for (int i = a; i <= b; i++)
                c += i * i;
            Console.WriteLine("Сумма квадратов: "+ c);
        }
    }
}
