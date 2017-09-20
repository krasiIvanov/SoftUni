using System;
using System.Linq;

namespace MostFrequentNumber
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCount = 0;
            int num = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                foreach (var item in numbers)
                {
                    if (numbers[i] == item)
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = numbers[i];
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}