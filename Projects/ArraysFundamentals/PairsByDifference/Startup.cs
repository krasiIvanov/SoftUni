using System;
using System.Linq;

namespace PairsByDifference
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1 + i; j < numbers.Length; j++)
                {
                    int diff = Math.Abs(numbers[i] - numbers[j]);
                    if (diff == num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}