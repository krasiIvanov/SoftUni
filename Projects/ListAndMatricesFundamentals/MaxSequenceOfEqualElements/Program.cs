using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int len = 1;
            int bestNum = 0;
            int tempLen = 1;
            for (int i = 0; i < nums.Count-1; i++)
            {
              
                if (nums[i]==nums[i+1])
                {
                    tempLen++;
                    if (tempLen>len)
                    {
                        len = tempLen;
                        bestNum = nums[i];
                    }
                }
                else
                {
                    tempLen = 1;
                }
                if (len==1)
                {
                    bestNum = nums[0];
                }
            }

            for (int i = 0; i < len; i++)
            {
                Console.Write(bestNum+" ");
            }
            Console.WriteLine();
        }
    }
}
