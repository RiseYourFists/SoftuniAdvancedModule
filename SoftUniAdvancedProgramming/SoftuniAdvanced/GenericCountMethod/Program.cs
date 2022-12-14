using GenericBoxOfString;
using System;

namespace GenericCountMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newBox = new Box<double>();

            var inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                var input = double.Parse(Console.ReadLine());
                newBox.Add(input);
            }
            var compare = double.Parse(Console.ReadLine());
            Console.WriteLine(newBox.CompareCount(compare));
        }
    }
}
