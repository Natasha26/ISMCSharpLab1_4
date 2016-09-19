using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = 1;
                for (int c = 1;c <= i;c++)
                f *= c;
                sum += f;
            }
                
            Console.WriteLine("Сумма факториалов: "+ sum);

           
        }
    }
}
