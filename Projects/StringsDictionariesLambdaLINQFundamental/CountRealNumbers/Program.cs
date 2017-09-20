using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SortedDictionary<decimal, int> count = new SortedDictionary<decimal, int>();

            foreach (var num in nums)
            {
                count[num] = 0;
            }
            foreach (var item in nums)
            {
                count[item]++;
            }

            foreach (var item in count.Keys.Reverse())
            {
                Console.WriteLine($"{item} -> {count[item]}");
            }

        }
    }
}
