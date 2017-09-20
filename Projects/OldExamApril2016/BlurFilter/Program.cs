using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurFilter
{
    class Program
    {
        static void Main(string[] args)
        {


            int blurAmount = int.Parse(Console.ReadLine());
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = size[0];
            int col = size[1];
            var matrix = new long[row,col];

            
            for (int r = 0; r < row; r++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = input[c];
                }

            }

            int[] cordinats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rowToblur = cordinats[0];
            int colToBLue = cordinats[1];

            int startRow = Math.Max(0, rowToblur - 1);
            int endRow = Math.Min(row - 1, rowToblur + 1);

            int startCol = Math.Max(0, colToBLue - 1);
            int endCol = Math.Min(col - 1, colToBLue + 1);
            for (int r = startRow; r <= endRow; r++)
            {
                for (int c = startCol; c <= endCol; c++)
                {
                    matrix[r, c] += blurAmount;
                }
            }

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(matrix[r,c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
