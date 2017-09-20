using System;

namespace RecursiveFibonacci
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = GetFibonachiNum(num);
            Console.WriteLine(result);
        }

        public static int GetFibonachiNum(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            if (num == 1)
            {
                return 1;
            }
            else
            {
                int fibNum = GetFibonachiNum(num - 1) + GetFibonachiNum(num - 2);
                return fibNum;
            }
        }
    }
}