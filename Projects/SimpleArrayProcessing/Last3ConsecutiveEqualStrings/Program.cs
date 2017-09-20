using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            string word = String.Empty;
            for (int i = 1; i < input.Length-1; i++)
            {
                if (input[i-1]==input[i]&& input[i]==input[i+1])
                {
                    word = input[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(word+" ");
            }
            Console.WriteLine();
        }
    }
}
