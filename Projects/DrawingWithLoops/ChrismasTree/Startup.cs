using System;

namespace ChrismasTree
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write(new string(' ', num + 1));
            Console.WriteLine("|");

            for (int row = 0; row < num; row++)
            {
                for (int spaces = 1; spaces < num - row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int rightStars = 0; rightStars <= row; rightStars++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int leftStars = 0; leftStars <= row; leftStars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}