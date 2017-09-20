using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LergestArray
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr1 = Console.ReadLine().Split(' ').ToArray();
            var arr2 = Console.ReadLine().Split(' ').ToArray();

            var count = LargestCommonEnd(arr1, arr2);
            Console.WriteLine(count);
            
        }
        static int LargestCommonEnd(
   string[] words1, string[] words2)
        {
            var rightCount = 0;
            while (rightCount < words1.Length &&
                   rightCount < words2.Length)
                if (words1[words1.Length - rightCount - 1] ==
                     words2[words2.Length - rightCount - 1])
                    rightCount++;
                else break;
            return rightCount;
        }

    }
}
