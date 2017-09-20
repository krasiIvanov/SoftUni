using System;

namespace PrimeOrNot
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = 1; i <= num; i++)
            {
                int tempNum;

                tempNum = num % i;
                if (tempNum == 0) flag++;
                if (flag > 2) break;
            }
            if (flag == 2) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}