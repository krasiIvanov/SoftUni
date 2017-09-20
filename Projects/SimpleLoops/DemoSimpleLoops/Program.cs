using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSimpleLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int oddSum =0;
            int evenSum = 0;
            for (int i = 1; i <= num; i++)
            {
                int num1 = int.Parse(Console.ReadLine());

                if (i%2==0)
                {
                    oddSum += num1;
                }
                else
                {
                    evenSum += num1;
                }
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes sum = "+oddSum);
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No diff = "+diff);
            }

        }
    }
}
