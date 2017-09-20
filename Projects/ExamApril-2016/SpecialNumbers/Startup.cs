using System;

namespace SpecialNumbers
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int tempNum = i;
                int firsDigit = tempNum % 10;
                tempNum /= 10;
                int secondDigit = tempNum % 10;
                tempNum /= 10;
                int thirdDigit = tempNum % 10;
                tempNum /= 10;
                int fourDigit = tempNum;

                if (firsDigit == 0 || secondDigit == 0 || thirdDigit == 0 || fourDigit == 0)
                {
                    continue;
                }
                else if (num % firsDigit == 0 && num % secondDigit == 0 && num % thirdDigit == 0 && num % fourDigit == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}