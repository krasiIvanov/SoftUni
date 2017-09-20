using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {


//3
//4
//A B C D
//E F G H
//I J K L




            int rows = int.Parse(Console.ReadLine());

            int cols = int.Parse(Console.ReadLine());

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                var items = line.Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = items[col]; 
                }
            }

            var result = new string[cols, rows];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[col,rows- row-1] = matrix[row, col];
                    
                }
                
            }
            
            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    Console.Write(result[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
