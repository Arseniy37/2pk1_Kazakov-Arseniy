using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {int count = 0;

          int[,] a = new int[5, 10];

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
               
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write( a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (a[i, j] == x)
                        Console.WriteLine(a[i, j]);
                }
            }

        }

