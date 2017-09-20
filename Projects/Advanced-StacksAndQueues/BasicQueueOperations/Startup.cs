using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int stackSize = comands[0];
            int dequeueTimes = comands[1];
            int containsNumber = comands[2];

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(nums);

            for (int i = 0; i < dequeueTimes; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(containsNumber))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine(numbers.Count);
            }
        }
    }
}