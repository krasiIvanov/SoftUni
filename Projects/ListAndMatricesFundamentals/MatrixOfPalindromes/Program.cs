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

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = nums[0];
            int col = nums[1];

            var matrix = new int[row, col];
            char ch = 'a';
            

            for (int r = 0; r < row; r++)
            {
                char midleChar = 'a';

                for (int c = 0; c < col; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        
                        
                        if (i==1)
                        {
                            midleChar = (char)('a' + r + c);
                            Console.Write(midleChar);
                        }
                        else
                        {
                            Console.Write(ch);
                        }
                    }
                    
                    Console.Write(" ");
                }
                
                
                ch++;
                
                Console.WriteLine();
            }

        }
    }
}
