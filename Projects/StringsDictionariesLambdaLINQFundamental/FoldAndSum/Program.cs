using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = nums.Length / 4;

            var row1First = nums.Take(k).Reverse();
            var row1Last = nums.Reverse().Take(k);
            int[] row1 = row1First.Concat(row1Last).ToArray();
            int[] row2 = nums.Skip(k).Take(k * 2).ToArray();

            for (int i = 0; i < k*2; i++)
            {
                row1[i] += row2[i];
            }
            Console.WriteLine(string.Join(" ",row1));
        }
    }
}
