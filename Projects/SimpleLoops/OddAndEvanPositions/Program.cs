using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvanPositions
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 1; i <= num; i++)
            {
                double nextNum = double.Parse(Console.ReadLine());

               
                    if (i%2==0)
                {
                    oddSum += nextNum;
                    if (nextNum < oddMin) oddMin = nextNum;
                    if (nextNum > oddMax) oddMax = nextNum;
                }
                    else
                {
                    evenSum+= nextNum;
                    if (nextNum < evenMin) evenMin = nextNum;
                    if (nextNum > evenMax) evenMax = nextNum;
                }

            }
            Console.WriteLine("EvenSum = {0},", evenSum);

            if (evenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin= No,");
            }
            else
            {
                Console.WriteLine("EvenMin = {0},", evenMin);
            }
            if (evenMax == int.MinValue)
            {
                Console.WriteLine("EvenMax= No,");
            }
            else
            {
                Console.WriteLine("EvenMax = {0}", evenMax);
            }

            Console.WriteLine("OddSum = {0},",oddSum);
            if (oddMin==int.MaxValue)
            {
                Console.WriteLine("OddMIn= No,");
            }
            else
            {
                Console.WriteLine("OddMin = {0},",oddMin);
            }
            if (oddMax == int.MinValue)
            {
                Console.WriteLine("OddMax= No,");
            }
            else
            {

                Console.WriteLine("OddMax = {0},", oddMax);
            }


        }
    }
}
