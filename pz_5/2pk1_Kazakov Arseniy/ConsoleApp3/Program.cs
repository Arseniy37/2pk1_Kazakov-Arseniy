using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Enumerable.Range(1, 50).Select(i => 2 * i)));
            Console.ReadLine();
        }
    }
}
