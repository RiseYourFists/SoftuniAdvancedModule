using System;
using System.Linq;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(input.Count);
            Console.WriteLine(input.Sum());
        }
    }
}
