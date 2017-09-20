using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = int.Parse(Console.ReadLine());

            var numbers = new bool[num + 1];

            for (int i = 2; i <= num; i++)
            {
                numbers[i] = true;
            }

            for (int j = 2; j <= num; j++)
            {
                if (numbers[j])
                {
                    Console.WriteLine(j);
                    var p = j * 2;
                    while (p<=num)
                    {
                        numbers[p] = false;
                        p = p + j;
                    }
                }
                
                
            }
            

        }
    }
}
