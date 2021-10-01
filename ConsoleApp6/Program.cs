using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), a = 0, b = 1; do { b += a; a = b - a; } while (b <= n); if (b - n < n - a) ;
            if (b - n < n - a)
                Console.WriteLine(b);
            else
                Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
