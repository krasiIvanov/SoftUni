using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestIncreasingSubsequence_LIS_
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if ((nums[j]<nums[i]) && (len[j]+1>len[i]))
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                    
                }
                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }
            List<int> longestSeq = new List<int>();

            while (lastIndex!=-1)
            {
                longestSeq.Add(nums[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestSeq.Reverse();
            Console.WriteLine(string.Join(" ",longestSeq));

        }
    }
}
