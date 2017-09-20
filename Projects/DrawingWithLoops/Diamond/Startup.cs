using System;

namespace Diamond
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int line = 1;
            int insideLine = 1;

            int botHalfLine = 0;
            int botInsline = num - 2;

            for (int topHalf = 0; topHalf < (num - 1) / 2; topHalf++)
            {
                Console.Write(new string('-', (num - line) / 2));
                if (num % 2 == 0 && topHalf == 0)
                {
                    Console.Write("**");
                }
                else
                {
                    Console.Write("*");
                }
                while (topHalf > 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(new string('-', insideLine + 1));
                    }
                    else
                    {
                        Console.Write(new string('-', insideLine));
                    }
                    Console.Write("*");
                    insideLine += 2;
                    break;
                }

                Console.Write(new string('-', (num - line) / 2));

                Console.WriteLine();
                line += 2;
            }

            for (int botHalf = 0; botHalf <= (num - 1) / 2; botHalf++)
            {
                Console.Write(new string('-', botHalfLine));
                Console.Write("*");
                if (botInsline > 0)
                {
                    Console.Write(new string('-', botInsline));
                }

                if (botHalf != (num - 1) / 2)
                {
                    Console.Write("*");
                }

                if (num % 2 == 0 && botHalf == (num - 1) / 2)
                {
                    Console.Write("*");
                }

                Console.Write(new string('-', botHalfLine));

                Console.WriteLine();
                botInsline -= 2;
                if (botInsline < 0) botInsline = 0;

                botHalfLine++;
            }
        }
    }
}