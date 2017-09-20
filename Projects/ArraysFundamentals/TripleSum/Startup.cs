using System;
using System.Linq;

namespace TripleSum
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int check = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];

                    for (int n = 0; n < arr.Length; n++)
                    {
                        if (sum == arr[n])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                            check++;
                        }
                    }
                }
            }
            if (check == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}