using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1. double x;
            double.TryParse(Console.ReadLine(), out x);
            double y = 7 * Math.Pow(x,2) - 3 * x + 4;
            Console.WriteLine(y);
            Console.ReadKey();*/

            /* 2. int radius;
             radius = int.Parse(Console.ReadLine());
             double length;
             length = 2 * Math.PI * radius;
             Console.WriteLine(length);
             Console.ReadKey();*/
            double length;
            double metr;
            length = double.Parse(Console.ReadLine());
            metr = length / 100;
            Console.WriteLine(metr);
            Console.ReadKey();

            /*5. int number;
            number = int.Parse(Console.ReadLine());
            int digit1, digit2,sum;
            digit1 = number / 10;
            digit2 = number % 10;
            sum = digit1 + digit2;
            Console.WriteLine(digit1);
            Console.WriteLine(digit2);
            Console.Write("Сумма цифр = ");
            Console.WriteLine(sum);
            Console.ReadKey();*/

        }

    }
}
