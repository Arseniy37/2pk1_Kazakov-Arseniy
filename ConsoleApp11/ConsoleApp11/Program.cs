using System;

class Programm
{
    static void Main(string[] args)
    {
        int i, j, k;
        int[] a = new int[20];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив: \n");
        for (i = 0; i < 20; i++)
        {
            a[i] = rnd.Next(-20, 20);
            Console.Write(" {0}", a[i]);
        }
        Console.WriteLine("\n");
        for (i = 0; i <= 10; i++)
            for (j = i + 1; j <= 9; j++)
                if (a[i] > a[j])
                {
                    k = a[i]; a[i] = a[j]; a[j] = k;
                }
        for (i = 10; i <= 20; i++)
            for (j = i + 1; j <= 19; j++)
                if (a[i] < a[j])
                {
                    k = a[i]; a[i] = a[j]; a[j] = k;
                }
        Console.WriteLine("Массив после сортировки: \n");
        for (i = 0; i <= 19; i++)
            Console.Write(" {0}", a[i]);
        Console.WriteLine("\n");
        Console.WriteLine("Для продолжения нажмите клавишу Enter");
        Console.ReadLine();
    }
}