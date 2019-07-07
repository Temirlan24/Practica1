using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Console.WriteLine("Введите данные в массив из 5 элементов:");
            int[] A = new int[5];
            int sumofAllElementA = 0, maxA, minA, sumEvenNumbers = 0;
            double sumofAllElementB = 0, maxB, minB, sumOddColums = 0;
            double[,] B = new double[3, 4];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
                if (A[i] % 2 == 0)
                {
                    sumEvenNumbers += A[i];
                }
            }
            minA = A.Min();
            sumofAllElementA = A.Sum();
            maxA = A.Max();

            Console.WriteLine("\nСумма всех элементов = {0}", sumofAllElementA);
            Console.WriteLine("Минимальный элемент = {0}", minA);
            Console.WriteLine("Максимальный элемент = {0}", maxA);
            Console.WriteLine("Сумма четных элементов = {0}", sumEvenNumbers);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Двумернный массив: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Thread.Sleep(20);
                    Random rnd = new Random();
                    B[i, j] = rnd.Next(0, 10);
                    Console.Write("{0} ", B[i, j]);
                }
                Console.WriteLine();
            }
            maxB = B[0, 0];
            minB = B[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumofAllElementB += B[i, j];
                    if (j % 2 != 0)
                    {
                        sumOddColums += B[i, j];
                    }
                    if (minB > B[i, j])
                    {
                        minB = B[i, j];
                    }
                    if (maxB < B[i, j])
                    {
                        maxB = B[i, j];
                    }
                }

            }
            Console.WriteLine("\nСумма всех элементов = {0}", sumofAllElementB);
            Console.WriteLine("Минимальный элемент = {0}", minB);
            Console.WriteLine("Максимальный элемент = {0}", maxB);
            Console.WriteLine("Сумма нечетных столбцов = {0}", sumOddColums);
            Console.ReadKey(); */

             /* 2. Console.WriteLine("Введите размер 1 массива: ");
             int sizeArrayFirst = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите размер 2 массива: ");
             int sizeArraySecond = int.Parse(Console.ReadLine());
             int[] arrayFirst = new int[sizeArrayFirst];
             int[] arraySecond = new int[sizeArraySecond];
             for (int i = 0, j = 0; i < sizeArrayFirst && j < sizeArraySecond; i++, j++)
             {
                 Random random = new Random();
                 Thread.Sleep(20);
                 arrayFirst[i] = random.Next(0, 20);
                 arraySecond[j] = random.Next(0, 20);
             }
             for (int i = 0; i < sizeArrayFirst; i++)
             {
                 Console.Write(arrayFirst[i] + " ");
             }
             Console.WriteLine();
             for (int i = 0; i < sizeArraySecond; i++)
             {
                 Console.Write(arraySecond[i] + " ");
             }
            Console.WriteLine();
            int[] sizeArrayThird = arrayFirst.Concat(arraySecond).Distinct().ToArray();
             
            foreach(var element in sizeArrayThird)
            {
                Console.Write(element + " ");
            }
             Console.ReadKey();*/

            /*3. var original = Console.ReadLine();
             var reversed = new string(original.Reverse().ToArray());
             if (original == reversed)
             {
                 Console.WriteLine("Строка является палиндромом");
             }
             else
             {
                 Console.WriteLine("Строка не является палиндромом");
             }
             Console.ReadKey();
             */
            /*4. Console.WriteLine("Напишите свое предложение");
            string sentence = Console.ReadLine();
            int wordCount = 1;
            for(int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i]==' ')
                {
                    wordCount++;
                }
            }
            Console.WriteLine("Количество слов = " + wordCount);
            Console.ReadKey();*/
            /*5. int[,] array = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Random random = new Random();
                    Thread.Sleep(20);
                    array[i, j] = random.Next(-100, 100);
                }
            }
            int maxArray = -100, minArray = 100, sumArray = 0; ;
            int positionMaxI = 0, positionMaxJ = 0, positionMinI = 0, positionMinJ = 0;
            bool count = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sumArray += array[i, j];
                    Console.Write(array[i, j] + "\t");
                    if (array[i, j] > maxArray)
                    {
                        maxArray = array[i, j];
                        positionMaxI = i;
                        positionMaxJ = j;
                    }
                    if (minArray > array[i, j])
                    {
                        minArray = array[i, j];
                        positionMinI = i;
                        positionMinJ = j;
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i == positionMaxI && j == positionMaxJ) || (i == positionMinI && j == positionMinJ))
                    {
                        if (count)
                        {
                            count = false;
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sumArray += array[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма элементов между минимальным и максимальным элементом = " + sumArray);
            Console.ReadKey();*/
        }
    }
}
