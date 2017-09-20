using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] typeAndSize = Console.ReadLine().Split(' ').ToArray();
            string type = typeAndSize[0];
            int row = int.Parse(typeAndSize[1]);
            int col = int.Parse(typeAndSize[2]);

            int[,] matrix = new int[row, col];

            if (type == "A")
            {
                int startNum = 1;
                for (int c = 0; c < col; c++)
                {

                    for (int r = 0; r < row; r++)
                    {
                        matrix[r, c] = startNum;
                        startNum++;
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();

                }
            }
            else if (type == "B")
            {
                int startNum = 1;
                for (int c = 0; c < col; c++)
                {
                    if (startNum % 2 == 0)
                    {
                        for (int r = 0; r < row; r++)
                        {
                            matrix[r, c] = startNum;
                            startNum--;
                        }
                        startNum += row + 1;
                    }
                    else
                    {
                        for (int r = 0; r < row; r++)
                        {
                            matrix[r, c] = startNum;
                            startNum++;
                        }
                        startNum += row - 1;
                    }

                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();

                }
            }
            else if (type == "C")
            {
                int startNUm = 1;

                for (int r = row - 1; r >= 0; r--)
                {
                    int startRow = r;
                    for (int i = 0; i < row - startRow; i++)
                    {
                        if (i > col - 1)
                        {
                            break;
                        }
                        matrix[startRow + i, i] = startNUm;
                        startNUm++;
                    }
                }

                for (int i = 1; i < col; i++)
                {
                    int startCol = i;
                    for (int j = 0; j < col - startCol; j++)
                    {
                        if (j > row - 1) { break; }
                        matrix[j, startCol + j] = startNUm; startNUm++;
                    }
                }
                //print
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();

                }

            }
            else if (type == "D")
            {
                int startNum = 1;
                int startRow = 0;
                int startCol = 0;
                while (startNum <= row * col)
                {
                    matrix[startRow, startCol] = startNum;
                    startNum++; ;

                    bool canGoDown = (startRow + 1) < row && matrix[startRow + 1, startCol] == 0 
                        && !((startCol - 1) >= 0 && matrix[startRow, startCol - 1] == 0);
                    if (canGoDown) { startRow++; continue; }
                    bool canGoRight = (startCol + 1) < col && matrix[startRow, startCol + 1] == 0;
                    if (canGoRight) { startCol++; continue; }
                    bool canGoUp = (startRow - 1) >= 0 && matrix[startRow - 1, startCol] == 0;
                    if (canGoUp) { startRow--; continue; }
                    bool canGoLeft = (startCol - 1) >= 0 && matrix[startRow, startCol - 1] == 0;
                    if (canGoLeft) { startCol--; continue; }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
