using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourglassSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[6, 6];

            for (int r = 0; r < 6; r++)
            {
                int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < 6; c++)
                {
                    matrix[r, c] = cells[c];
                }
            }
            long maxSum = long.MinValue;
            for (int r = 0; r < 6-2; r++)
            {
                for (int c = 0; c < 6-2; c++)
                {
                    long sum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] + matrix[r + 1, c + 1] + matrix[r + 2, c] + matrix[r + 2, c + 1] + 
                        matrix[r+2, c+2];

                    if (sum>maxSum)
                    {
                        maxSum = sum;

                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
