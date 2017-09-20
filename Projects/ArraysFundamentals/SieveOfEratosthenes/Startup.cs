using System;

namespace SieveOfEratosthenes
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool[] sieve = new bool[num + 1];
            for (int i = 0; i <= num; i++)
            {
                sieve[i] = true;
            }
            sieve[0] = sieve[1] = false;

            for (int i = 2; i <= num; i++)
            {
                if (sieve[i])
                {
                    Console.Write(i + " ");
                    int start = 2 * i;
                    while (start <= num)
                    {
                        sieve[start] = false;
                        start += num;
                    }
                }
            }
        }
    }
}