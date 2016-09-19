using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны a: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны в: ");
            uint b = uint.Parse(Console.ReadLine());
            uint x = 2 * (a + b);
            Console.Write("Периметр прямоугольника: ");
            Console.WriteLine(x);
            uint y = a * b;
            Console.Write("Площадь прямоугольника: ");
            Console.WriteLine(y);
        }
    }
}
