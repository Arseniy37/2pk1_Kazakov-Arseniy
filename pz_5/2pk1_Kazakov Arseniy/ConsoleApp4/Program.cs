using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            int j = 40;
            for (; ; )
            {
                if (i != 18 && j != 18)
                {
                    i++;
                    j--;
                }
                else if (j != 18) j--;
                else break;
                Console.WriteLine(i + "," + j);
            }
        
        }
    }
}
