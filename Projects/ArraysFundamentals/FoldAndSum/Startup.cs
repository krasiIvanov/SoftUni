using System;
using System.Linq;

namespace FoldAndSum
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = arr.Length / 4;
            int[] firstNums = new int[k];
            int[] lastNums = new int[k];
            int[] midleNums = new int[k * 2];
            int[] firstAndLast = new int[k * 2];

            for (int i = 0; i < firstNums.Length; i++)
            {
                firstNums[i] = arr[i];
            }

            for (int i = 0; i < firstNums.Length; i++)
            {
                lastNums[i] = arr[k * 3 + i];
            }

            for (int i = 0; i < midleNums.Length; i++)
            {
                midleNums[i] = arr[k + i];
            }
            Array.Reverse(firstNums);
            Array.Reverse(lastNums);
            for (int i = 0; i < firstAndLast.Length; i++)
            {
                if (k > i)
                {
                    firstAndLast[i] = firstNums[i];
                }
                else
                {
                    firstAndLast[i] = lastNums[i - k];
                }
            }
            int[] sum = new int[k * 2];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstAndLast[i] + midleNums[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}