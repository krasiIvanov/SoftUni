using System;

namespace Romb
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int spaces = 0; spaces <
                    num - row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < row; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            for (int col = 1; col < num; col++)
            {
                for (int spaces = 0; spaces < col; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < num - col; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}