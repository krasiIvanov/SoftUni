using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = GetFibonachi(num);
            Console.WriteLine(result);
        }

        public static int GetFibonachi(int num)
        {
            Stack<int> nums = new Stack<int>();
            if (num == 0) return 1;
            if (num == 1) return 1;
            nums.Push(1);
            nums.Push(1);

            for (int i = 2; i <= num; i++)
            {
                int prev = nums.Pop();
                int prevPrev = nums.Pop();
                int result = prev + prevPrev;
                nums.Push(prev);
                nums.Push(result);
            }
            return nums.Peek();
        }
    }
}