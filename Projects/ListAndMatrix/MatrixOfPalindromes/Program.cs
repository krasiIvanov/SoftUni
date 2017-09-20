using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * aaa aba aca ada aea afa
            */
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            string[,] matrix = new string[row, col];


            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {

                    matrix[r, c] = "" +(char)('a' + r) + (char)('a' + r + c)+(char)('a'+r) ;


                }
                
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
