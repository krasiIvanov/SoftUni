using System;

namespace NOD
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int nod = 0;
            if (firstNum < secondNum)
            {
                nod = firstNum;
                firstNum = secondNum;
                secondNum = nod;
            }
            for (int i = 1; i <= firstNum; i++)
            {
                if (firstNum % i == 0 && secondNum % i == 0)
                {
                    nod = i;
                }
            }
            Console.WriteLine(nod);
        }
    }
}