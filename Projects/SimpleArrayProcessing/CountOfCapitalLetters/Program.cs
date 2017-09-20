using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int charCode = input[i][0];
                if (charCode>64 && charCode<91)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
