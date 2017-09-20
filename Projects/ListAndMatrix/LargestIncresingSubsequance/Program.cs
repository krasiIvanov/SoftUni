using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestIncresingSubsequance
{
    class Program
    {
        static void Main(string[] args)
        {
            //pos 0 1 2 3 4 5
            //seq 2 3 9 8 5 6
            //len 1 2 3 3 3 4
          //prev -1 0 1 1 1 4

            var seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var len = new int[seq.Length];
            var prev = new int[seq.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int x = 0; x < seq.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;

                for (int i = 0; i < x; i++)
                {
                    if (seq[i] < seq[x] && len[i] >= len[x])
                    {
                        len[x] = 1 + len[i];
                        prev[x] = i;
                    }
                }

                if (len[x] > maxLen)
                {
                    maxLen = len[x];
                    lastIndex = x;
                }
            }

            var result = new List<int>();
            while (lastIndex != -1)
            {
                result.Add(seq[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
