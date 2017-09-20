using System;

namespace NumberPiramid
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = 0;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write((tempNum + 1) + " ");
                    tempNum++;
                    if (tempNum == num)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (tempNum == num)
                {
                    break;
                }
            }
        }
    }
}