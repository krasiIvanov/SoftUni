using System;

namespace MatrixOfNumber
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = 0;
            int tempNum2 = 1;
            int tempNum3 = 0;
            int tempNum4 = num - 1;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write((tempNum + 1) + " ");
                    tempNum++;
                    tempNum3++;
                    if (tempNum == num)
                    {
                        for (int k = tempNum3; k < num; k++)
                        {
                            Console.Write((tempNum4) + " ");
                            tempNum4--;
                        }
                        break;
                    }
                }
                Console.WriteLine();
                if (tempNum == num)
                {
                    tempNum = tempNum2;
                    tempNum3 = 0;
                    tempNum4 = num - 1;
                }

                tempNum2++;
            }
        }
    }
}