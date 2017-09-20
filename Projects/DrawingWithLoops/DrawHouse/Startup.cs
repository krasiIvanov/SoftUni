using System;

namespace DrawHouse
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int line = 1;
            int stars = 2;

            for (int i = 1; i < (num + 1) / 2; i++)
            {
                Console.Write(new string('-', (num - line) / 2));
                if (num % 2 == 0)
                {
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', (num - line) / 2));
                }
                else
                {
                    Console.Write(new string('*', stars - 1));
                    Console.Write(new string('-', (num - line) / 2));
                }

                Console.WriteLine();
                line += 2;
                stars += 2;
            }
            Console.WriteLine(new string('*', num));

            for (int i = 0; i < num / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', num - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}