using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int stackSize = comands[0];
            int popTimes = comands[1];
            int containsNumber = comands[2];

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(nums);

            for (int i = 0; i < popTimes; i++)
            {
                numbers.Pop();
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