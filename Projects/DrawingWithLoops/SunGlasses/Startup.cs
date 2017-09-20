using System;

namespace SunGlasses
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int leftStars = 0; leftStars < num * 2; leftStars++)
            {
                Console.Write("*");
            }

            Console.Write(new string(' ', num));

            for (int rightStars = 0; rightStars < num * 2; rightStars++)
            {
                Console.Write("*");
            }
            // Console.WriteLine();
            Console.WriteLine();

            for (int leftRow = 0; leftRow < num - 2; leftRow++)
            {
                Console.Write("*");
                for (int leftPart = 0; leftPart < num + num - 2; leftPart++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                if (leftRow == (num - 1) / 2 - 1)
                {
                    Console.Write(new string('|', num));
                }
                else
                {
                    Console.Write(new string(' ', num));
                }

                //-------------------------------
                Console.Write("*");
                for (int leftPart = 0; leftPart < num + num - 2; leftPart++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                Console.WriteLine();
            }

            for (int leftStars = 0; leftStars < num * 2; leftStars++)
            {
                Console.Write("*");
            }
            Console.Write(new string(' ', num));
            for (int rightStars = 0; rightStars < num * 2; rightStars++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}