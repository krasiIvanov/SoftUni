using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {

            int startPosition = int.Parse(Console.ReadLine());
            int endPosition = int.Parse(Console.ReadLine());

            FibonacciNumbers fibonacci = new FibonacciNumbers();

            long a = 0;
            long b = 1;
            long c;

            fibonacci.numbers.Add(a);
            fibonacci.numbers.Add(b);
            for (int i = 2; i <= endPosition; i++)
            {
                c = a + b;
                fibonacci.numbers.Add(c);
                a = b;
                b = c;
            }

            Console.WriteLine(string.Join(", ",fibonacci.GetFibNumbersInRange(startPosition,endPosition)));

        }
    }
}
