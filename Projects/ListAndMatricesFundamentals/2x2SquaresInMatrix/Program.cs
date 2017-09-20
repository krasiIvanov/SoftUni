using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int row = size[0];
            int col = size[1];

            char[,] matrix = new char[row, col];
            for (int r = 0; r < row; r++)
            {
                char[] cell = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = cell[c];
                }
            }
            int count = 0;
            for (int r = 0; r < row-1; r++)
            {
                for (int c = 0; c < col-1; c++)
                {
                    if (matrix[r,c]==matrix[r,c+1] && matrix[r, c] == matrix[r+1, c] && matrix[r, c] == matrix[r+1, c + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
