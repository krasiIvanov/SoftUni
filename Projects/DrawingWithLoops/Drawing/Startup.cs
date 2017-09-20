using System;

namespace Drawing
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int j = 0; j < num - 2; j++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int m = 0; m < num - 2; m++)
            {
                Console.Write("|");
                for (int n = 0; n < num - 2; n++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int h = 0; h < num - 2; h++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}