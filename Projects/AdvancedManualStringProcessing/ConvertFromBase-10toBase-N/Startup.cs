using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConvertFromBase_10toBase_N
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger baseToConvert = BigInteger.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);
            ;
            List<BigInteger> result = new List<BigInteger>();

            while (true)
            {
                BigInteger ends = 0;
                ends = num % baseToConvert;
                result.Add(ends);
                if (ends != 0)
                {
                    num = (num - ends) / baseToConvert;
                    if (num < baseToConvert)
                    {
                        result.Add(num);
                        break;
                    }
                }
                else
                {
                    num /= baseToConvert;
                    if (num < baseToConvert)
                    {
                        result.Add(num);
                        break;
                    }
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}