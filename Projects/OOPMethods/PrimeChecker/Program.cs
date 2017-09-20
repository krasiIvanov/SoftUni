using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num==1 || num==0||num==2)
            {
                isPrime = true;
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(num); i++)
                {
                    if (num%i==0)
                    {
                        isPrime = false;
                    }
                }
            }
            Number number = new Number(num, isPrime);
            Console.WriteLine($"{number.GetNextPrime()}, {number.isPrime}");
        }
    }
}
