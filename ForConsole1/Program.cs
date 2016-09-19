using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {

             
            Console.WriteLine("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            int b = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = a; i <= b; i++)
                c *= i;
            Console.WriteLine("Произведение чисел: " + c);
            

        }
    }
}
