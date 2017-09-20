using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();

            for (int i = 0; i < num; i++)
            {
                int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int operation = comands[0];
                if (operation == 1)
                {
                    int numberPush = comands[1];
                    numbers.Push(numberPush);
                    if (maxNumbers.Count == 0 || numberPush >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(numberPush);
                    }
                }
                else if (operation == 2)
                {
                    int topElement = numbers.Pop();
                    int curentMaxNumber = maxNumbers.Peek();
                    if (curentMaxNumber == topElement)
                    {
                        maxNumbers.Pop();
                    }
                }
                else if (operation == 3)
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}