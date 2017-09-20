using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] days = new int[num];

            Stack<int> tempNumberStack = new Stack<int>();
            tempNumberStack.Push(0);

            for (int i = 0; i < plants.Length; i++)
            {
                int maxDay = 0;
                while (tempNumberStack.Count > 0 && plants[tempNumberStack.Peek()] >= plants[i])
                {
                    maxDay = Math.Max(maxDay, days[tempNumberStack.Pop()]);
                }
                if (tempNumberStack.Count > 0)
                {
                    days[i] = maxDay + 1;
                }
                tempNumberStack.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}