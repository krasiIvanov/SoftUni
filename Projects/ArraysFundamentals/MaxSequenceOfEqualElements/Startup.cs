using System;
using System.Linq;

namespace MaxSeqInc_13._05._2016
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int l = numbers.Length;

            MaxIncSequence(numbers, l);
        }

        private static void MaxIncSequence(int[] numbers, int l)
        {
            int len = 0;
            int start = 0;
            int maxLen = 0;
            int bestStart = 0;

            for (int i = 1; i < l; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    len++;
                    start = i - len;

                    if (len > maxLen)
                    {
                        maxLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    len = 0;
                }
            }
            for (int iWrite = bestStart; iWrite <= (bestStart + maxLen); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}