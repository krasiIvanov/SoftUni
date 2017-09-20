using System;

namespace Diapason_1_100
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 100)
            {
                for (int i = num; i < 1 || i > 100; i = num)
                {
                    Console.WriteLine("Invalid Nmber");
                    Console.Write("Еnter a number in the range [1...100]: ");
                    int num1 = int.Parse(Console.ReadLine());

                    if (num1 >= 1 && num1 <= 100)
                    {
                        Console.WriteLine("The number is: " + num1);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The number is: " + num);
            }
        }
    }
}