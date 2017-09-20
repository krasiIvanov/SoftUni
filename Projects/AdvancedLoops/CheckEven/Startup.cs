using System;

namespace CheckEven
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                Console.Write("Enter even number: ");

                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)

                    {
                        Console.WriteLine("Even number entered: " + num);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number!!!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!!!");
                }
            }
        }
    }
}