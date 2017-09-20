using System;
using System.Linq;

namespace Demo
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Min = {arr.Min()}");
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"First = {arr.First()}");
            Console.WriteLine($"Last = {arr.Last()}");
            Console.WriteLine($"Avg = {arr.Average()}");
        }
    }
}