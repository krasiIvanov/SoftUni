using System;
using System.Linq;

namespace RotateToRight
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int[] SumArr = new int[arr.Length];
            for (int i = 0; i < num; i++)
            {
                int[] tempArr = new int[arr.Length];
                tempArr[0] = arr.Last();
                for (int j = 1; j < arr.Length; j++)
                {
                    tempArr[j] = arr[j - 1];
                }
                for (int n = 0; n < SumArr.Length; n++)
                {
                    SumArr[n] += tempArr[n];
                }

                arr = tempArr;
            }

            Console.WriteLine("sum[] = " + string.Join(" ", SumArr));
        }
    }
}