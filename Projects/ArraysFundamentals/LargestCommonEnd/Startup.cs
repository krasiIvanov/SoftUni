using System;

namespace LargestCommonEnd
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int min = Math.Min(arr1.Length, arr2.Length);

            int leftCount = ArrCommonCount(min, arr1, arr2);
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            int rightCount = ArrCommonCount(min, arr1, arr2);
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }

        private static int ArrCommonCount(int min, string[] arr1, string[] arr2)
        {
            int count = 0;
            for (int i = 0; i < min; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
                else break;
            }
            return count;
        }
    }
}