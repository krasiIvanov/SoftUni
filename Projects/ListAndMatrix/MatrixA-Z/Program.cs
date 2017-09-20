using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixA_Z
{
    class Program
    {
        static void Main(string[] args)
        {


            int row = int.Parse(Console.ReadLine());

            int col = int.Parse(Console.ReadLine());

            var matrix = new char[row, col];
            char latter = 'A';
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = latter;
                    Console.Write(latter);
                    latter++;
                    
                }
                Console.WriteLine();
            }

            
        }
    }
}
