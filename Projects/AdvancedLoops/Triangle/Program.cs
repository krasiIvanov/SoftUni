using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int spaces = 0; spaces < num - row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < row; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();

            }


        }
    }
}
