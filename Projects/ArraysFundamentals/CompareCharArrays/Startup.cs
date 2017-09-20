using System;
using System.Linq;

namespace CompareCharArrays
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int min = Math.Min(arr1.Length, arr2.Length);

            bool flag = false;
            for (int i = 0; i < min; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    flag = true;
                    break;
                }
                else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                if (arr1.Length >= arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
            }
            else if (flag == false)
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
        }
    }
}