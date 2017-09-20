using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());
            int dif = DifferenceOfDiagonals(num);
            Console.WriteLine(dif);
        }

        private static int DifferenceOfDiagonals(int num)
        {
            int row = num;
            int col = num;
            int[,] matrix = new int[row, col];

            for (int r = 0; r < row; r++)
            {
                int[] cell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = cell[c];
                }
            }
            int firstSum = 0;
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {

                    firstSum += matrix[r + c, c];


                }
                break;
            }
            int secondSum = 0;
            for (int r = row - 1; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {

                    secondSum += matrix[r - c, c];


                }
                break;
            }
            int dif = Math.Abs(firstSum - secondSum);
            return dif;
        }
    }
}
