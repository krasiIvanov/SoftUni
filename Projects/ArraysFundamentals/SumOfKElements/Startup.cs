using System;

namespace SumOfKElements
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int[] arr = new int[num1];
            arr[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = SumOfElements(arr, i - num2, i - 1);
            }
            Console.WriteLine(string.Join(" ", arr));
        }

        private static int SumOfElements(int[] arr, int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i >= 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}