using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            bool symetric = true;

            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i]!=input[input.Length-1-i])
                {
                    symetric = false;
                    break;
                }
            }
            if (symetric)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
