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
            /*3. double length;
            double metr;
            length = double.Parse(Console.ReadLine());
            metr = length / 100;
            Console.Write(metr);
            Console.WriteLine(" метр");
            Console.ReadKey();
            */
            /* 4. int day = 234;
            double week = day / 7;
            Console.Write("Прошло ");
            Console.Write(week);
            Console.WriteLine(" недель");
            Console.ReadKey();*/
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

            /*6. int number = int.Parse(Console.ReadLine());
            int digit1, digit2, digit3, digit4;
            digit1 = number / 1000;
            digit2 = (number / 100) % 10;
            digit3 = (number / 10) % 10;
            digit4 = number % 10;
            int sum , product;
            sum = digit1 + digit2 + digit3 + digit4;
            product = digit1 * digit2 * digit3 * digit4;
            Console.WriteLine("Сумма = {0}", sum);
            Console.WriteLine("Произведение = {0}", product);
            Console.ReadKey();*/

            /* 7. int number = 456;
            int digit1, digit2, digit3;
            digit1 = number / 100;
            digit2=(number/10)% 10;
            digit3 = number % 10;
            Console.Write("X = {0}{1}{2}", digit1, digit3, digit2);
            Console.ReadKey();*/
            //8
            bool X = true, Y = false;
            if (!X && !Y)
            {
                Console.WriteLine("A variant");
            }
            if(X ||(!X && Y))
            {
                Console.WriteLine("B variant");
            }
            if ((!X && Y) || Y)
            {
                Console.WriteLine("C variant");
            }
            Console.ReadKey();
        }

    }
}

