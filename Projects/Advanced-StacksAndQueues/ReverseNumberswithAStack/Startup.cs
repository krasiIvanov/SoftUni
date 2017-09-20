using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumberswithAStack
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> reverseStack = new Stack<int>(numbers);

            Console.WriteLine(string.Join(" ", reverseStack));
        }
    }
}