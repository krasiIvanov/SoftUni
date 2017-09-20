using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlatform3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = size[0];
            int col = size[1];

            int[,] matrix = new int[row, col];
            

            for (int r = 0; r < row; r++)
            {
                int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = cells[c];
                }
            }
            long maxSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            
            for (int r = 0; r < row-2; r++)
            {
                for (int c = 0; c < col-2; c++)
                {
                     long sum = (long)matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] + matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                        matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestRow = r;
                        bestCol = c;
                        
                    }
                }
                
            }
            Console.WriteLine(maxSum);
            for (int r = bestRow; r < bestRow+3; r++)
            {
                for (int c = bestCol; c < bestCol+3; c++)
                {
                    Console.Write(matrix[r,c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
