using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] count = new int[nums.Max()+1];

            for (int i = 0; i < nums.Count(); i++)
            {
                int num = nums[i];
                count[num]++;
            }
            int serachNum = int.Parse(Console.ReadLine());
            Console.WriteLine(count[serachNum]);
        }
    }
}
