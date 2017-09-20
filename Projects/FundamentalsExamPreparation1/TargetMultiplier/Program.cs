using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int[] cord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int row = cord[0];
                int col = cord[1];

                int[,] matrix = new int[row, col];

                for (int r = 0; r < row; r++)
                {
                    int[] fillNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int c = 0; c < col; c++)
                    {
                        matrix[r, c] = fillNums[c];
                    }
                }

                int[] targetNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int targetRow = targetNum[0];
                int targetCol = targetNum[1];
                int multiplier = matrix[targetRow, targetCol];
                int count = matrix[targetRow - 1, targetCol - 1] + matrix[targetRow - 1, targetCol] + matrix[targetRow - 1, targetCol + 1] + matrix[targetRow, targetCol - 1] + matrix[targetRow, targetCol + 1] + matrix[targetRow + 1, targetCol - 1] + matrix[targetRow + 1, targetCol] + matrix[targetRow + 1, targetCol + 1];


                int startRow = targetRow - 1;
                int endRow = targetRow + 1;
                int startCol = targetCol - 1;
                int endCol = targetCol + 1;

                for (int r = startRow; r <= endRow; r++)
                {
                    for (int c = startCol; c <= endCol; c++)
                    {

                        matrix[r, c] *= multiplier;

                    }
                }

                matrix[targetRow, targetCol] = multiplier * count;

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < col; c++)
                    {
                        Console.Write(matrix[r, c] + " ");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
